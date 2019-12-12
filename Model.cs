using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Diagnostics;

namespace JTPlan {
	public class Record {
		public int id = 0;
	}
	
	public class ContactRecord : Record {
		public string name;
		public string contact;
	}
	
	public class EventRecord : Record {
		public int d, m, y;
		public float since = 0;
		public float length = 0;
		public string data;
	}
	
	public class ActivityRecord : Record {
		public sbyte days = 0;
		public int d, m, y;
		public int dEnd, mEnd, yEnd;
		public string data;
		//public enum Day { Mo, Tu, We, Th, Fr, Sa, Su };
		public bool Mo {
			get { return (days & 1) > 0; }
			set { days&= ~1; if(value) days|= 1; }
		}
		public bool Tu {
			get { return (days & 2) > 0; }
			set { days&= ~2; if(value) days|= 2; }
		}
		public bool We {
			get { return (days & 4) > 0; }
			set { days&= ~4; if(value) days|= 4; }
		}
		public bool Th {
			get { return (days & 8) > 0; }
			set { days&= ~8; if(value) days|= 8; }			
		}
		public bool Fr {
			get { return (days & 16) > 0; }
			set { days&= ~16; if(value) days|= 16; }			
		}
		public bool Sa {
			get { return (days & 32) > 0; }
			set { days&= ~32; if(value) days|= 32; }
		}
		public bool Su {
			get { return (days & 64) > 0; }
			set { days&= ~64; if(value) days|= 64; }
		}
	}
	
	public class ActivityDataRecord : Record {
		public int activityId = 0;
		public int d, m, y;
		public int dEnd, mEnd, yEnd;
		public bool active;
		public string memo;		
	}
	
	public static class Model {
		public static SQLiteConnection db;
		public static Dictionary<int,EventRecord> allEvents = new Dictionary<int,EventRecord>();
		public static Dictionary<int, List<EventRecord>> events = new Dictionary<int, List<EventRecord>>();
		public static Dictionary<int,ActivityRecord> activities = new Dictionary<int,ActivityRecord>();
		public static List<ActivityDataRecord> activitiesData = new List<ActivityDataRecord>();
		public static Dictionary<int,ContactRecord> contacts = new Dictionary<int,ContactRecord>();
		
		delegate string SSFn(string s);
		delegate string SFFn(float f);
		static SSFn s = Extensions.SQLiteEscape;
		static SFFn n = Extensions.SQLiteFloat;
		public static bool opened = false;
		static string[] db_activities = { "d", "m", "y", "dEnd", "mEnd", "yEnd", "days", "data" };
		static string[] db_activitiesData = { "activityId", "d", "m", "y", "memo" };
		static string[] db_events = { "d", "m", "y", "data", "since", "length" };
		static string[] db_contacts = { "name", "contact" };
		
		static bool testTable(string table, string[] columns) {
			if(!opened) return false;
			var cmd = new SQLiteCommand("SELECT * FROM "+table+" WHERE 1=0", db);
			SQLiteDataReader reader;
			try { reader = cmd.ExecuteReader(); } catch(Exception) { return false; }
			for(int i=0; i<10; ++i) {
				try { if(columns[i]!=reader.GetName(i)) { Debug.WriteLine("{0},{1}", columns[i], reader.GetName(i)); return false; }}
				catch(Exception) { return true; }
			}
			return true;
		}
		
		public static void FixDB() {
			var sql1 = @"CREATE TABLE IF NOT EXISTS activities (
				d INTEGER, m INTEGER, y INTEGER,
				dEnd INTEGER, mEnd INTEGER,	yEnd INTEGER,
				days INTEGER, data TEXT)";
			new SQLiteCommand(sql1, db).ExecuteNonQuery();
			var sql2 = @"CREATE TABLE IF NOT EXISTS contacts (
				name TEXT, contact TEXT)";
			new SQLiteCommand(sql2, db).ExecuteNonQuery();
			var sql3 = @"CREATE TABLE IF NOT EXISTS events (
				d INTEGER, m INTEGER, y INTEGER,
				data TEXT, since NUMERIC, length NUMERIC)";
			new SQLiteCommand(sql3, db).ExecuteNonQuery();
			var sql4 = @"CREATE TABLE IF NOT EXISTS activitiesData (
				activityId INTEGER,
				d INTEGER, m INTEGER, y INTEGER,
				memo TEXT)";
			new SQLiteCommand(sql4, db).ExecuteNonQuery();
		}
		
		public static void Load() {
			loadEvents();
			loadActivities();
			loadActivitiesData();
			loadContacts();
		}
		
		public static bool Open(string dbName="calendar.db", bool force=false) {
			if(!File.Exists(dbName) && !force) return false; // db not exists
			else if(File.Exists(dbName) && new FileInfo(dbName).Length==0 && !force) return false; // db is empty file
			db = new SQLiteConnection("Data Source="+dbName+";Version=3;");
			db.Open();
			if(force) FixDB();
			Model.opened = true;
			return true;
		}
		
		public static bool Check(string dbName="calendar.db") {
			if(!testTable("activities", db_activities)) return false;
			if(!testTable("activitiesData", db_activitiesData)) return false;
			if(!testTable("events", db_events)) return false;
			if(!testTable("contacts", db_contacts)) return false;
			return true;
		}
		
		public static int[] Merge(string dbFile) {
			int[] result = new int[4];
			string sql = String.Format("ATTACH '{0}' AS m", dbFile);
			new SQLiteCommand(sql, db).ExecuteNonQuery();
			string sql1 = @"INSERT INTO events
				SELECT append.* FROM m.events AS append
				LEFT OUTER JOIN events AS orig
				ON append.rowid=orig.rowid AND append.d=orig.d
				WHERE orig.d IS NULL";
			result[0] = new SQLiteCommand(sql1, db).ExecuteNonQuery();
			string sql2 = @"INSERT INTO activities
				SELECT append.* FROM m.activities AS append
				LEFT OUTER JOIN activities AS orig
				ON append.rowid=orig.rowid AND append.d=orig.d
				WHERE orig.d IS NULL";
			result[1] = new SQLiteCommand(sql2, db).ExecuteNonQuery();
			string sql3 = @"INSERT INTO contacts
				SELECT append.* FROM m.contacts AS append
				LEFT OUTER JOIN contacts AS orig
				ON append.rowid=orig.rowid AND append.name=orig.name
				WHERE orig.name IS NULL";
			result[2] = new SQLiteCommand(sql3, db).ExecuteNonQuery();
			string sql4 = @"INSERT INTO activitiesData
				SELECT append.* FROM m.activitiesData AS append
				LEFT OUTER JOIN activitiesData AS orig
				ON append.rowid=orig.rowid AND append.d=orig.d
				WHERE orig.d IS NULL";
			result[3] = new SQLiteCommand(sql4, db).ExecuteNonQuery();
			new SQLiteCommand("DETACH m", db).ExecuteNonQuery();
			return result;
		}
		
		public static void Close() {
			if(opened) db.Close();
			db.Dispose();
			// GC needs to be called or else the file resources are not released!
			GC.Collect();
			GC.WaitForPendingFinalizers();
			opened = false;
		}
		
		public static void loadEvents() {
			events.Clear();
			if(!opened) return;
			string sql = "SELECT rowid, d,m,y, since,length,data FROM events";
			var cmd = new SQLiteCommand(sql, db);
			SQLiteDataReader reader = cmd.ExecuteReader();
			while(reader.Read()) {
				var item = new EventRecord();
				item.id = Convert.ToInt32(reader["rowid"]);
				item.since = Convert.ToSingle(reader["since"]);
				item.length = Convert.ToSingle(reader["length"]);
				item.data = reader["data"].ToString();
				item.d = Convert.ToInt32(reader["d"]);
				item.m = Convert.ToInt32(reader["m"]);
				item.y = Convert.ToInt32(reader["y"]);
				allEvents[item.id] = item;
			}
		}
		
		public static void loadMonthEvents(int year, int month) {
			events = new Dictionary<int, List<EventRecord>>();
			if(!opened) return;
			var filter = from ev in allEvents.Values
				where ev.y==year && ev.m==month
				orderby ev.since ascending
				select ev;
			foreach(EventRecord rec in filter) {
				if(!events.ContainsKey(rec.d)) events[rec.d] = new List<EventRecord>();
				events[rec.d].Add(rec);
			}
		}
		
		public static void loadActivities() {
			activities.Clear();
			if(!opened) return;
			string sql = "SELECT rowid, d,m,y, dEnd,mEnd,Yend, days,data FROM activities";
			var cmd = new SQLiteCommand(sql, db);
			SQLiteDataReader reader = cmd.ExecuteReader();
			while(reader.Read()) {
				var item = new ActivityRecord();
				item.id = Convert.ToInt32(reader["rowid"]);
				item.d = Convert.ToInt32(reader["d"]);
				item.m = Convert.ToInt32(reader["m"]);
				item.y = Convert.ToInt32(reader["y"]);
				item.dEnd = Convert.ToInt32(reader["dEnd"]);
				item.mEnd = Convert.ToInt32(reader["mEnd"]);
				item.yEnd = Convert.ToInt32(reader["yEnd"]);
				item.days = Convert.ToSByte(reader["days"]);
				item.data = reader["data"].ToString();
				activities[item.id] = item;
			}
		}
		
		public static void loadActivitiesData() {
			activitiesData.Clear();
			if(!opened) return;
			string sql = "SELECT rowid,activityId, d,m,y, memo FROM activitiesData";
			var cmd = new SQLiteCommand(sql, db);
			SQLiteDataReader reader = cmd.ExecuteReader();
			while(reader.Read()) {
				var item = new ActivityDataRecord();
				item.id = Convert.ToInt32(reader["rowid"]);
				item.activityId = Convert.ToInt32(reader["activityId"]);
				item.d = Convert.ToInt32(reader["d"]);
				item.m = Convert.ToInt32(reader["m"]);
				item.y = Convert.ToInt32(reader["y"]);
				item.memo = reader["memo"].ToString();
				activitiesData.Add(item);
			}
		}

		public static void loadContacts() {
			contacts.Clear();
			if(!opened) return;
			string sql = "SELECT rowid, name,contact FROM contacts ORDER BY name";
			var cmd = new SQLiteCommand(sql, db);
			SQLiteDataReader reader = cmd.ExecuteReader();
			while(reader.Read()) {
				var item = new ContactRecord();
				item.id = Convert.ToInt32(reader["rowid"]);
				item.name = reader["name"].ToString();
				item.contact = reader["contact"].ToString();
				contacts[item.id] = item;
			}
		}
		
		public static void Save(string sql) {
			if(!opened) return;
			var cmd = new SQLiteCommand(sql, Model.db);
			cmd.ExecuteNonQuery();
		}
		
		public static int Insert(string sql) {
			if(!opened) return 0;
			SQLiteTransaction transaction = Model.db.BeginTransaction();
			var cmd = new SQLiteCommand(sql, Model.db);
			cmd.ExecuteNonQuery();
			int result = (int)(Model.db.LastInsertRowId);
			transaction.Commit();
			return result;
		}

		public static void updateEvent(EventRecord rec) {
			if(!opened) return;
			string sql = String.Format("UPDATE events SET since={0}, length={1}, data='{2}' WHERE rowid={3}",
				n(rec.since), n(rec.length), s(rec.data), rec.id
			);
			Save(sql);
			allEvents[rec.id] = rec;
			if(!events.ContainsKey(rec.d)) events[rec.d] = new List<EventRecord>();
			var src = events[rec.d];
			var index = src.FindIndex(i=>i.id==rec.id);
			if(index!=0) src[index] = rec;
			src.Sort((a,b)=>a.since.CompareTo(b.since));
		}
		
		public static void insertEvent(EventRecord rec) {
			if(!opened) return;
			string sql = String.Format("INSERT INTO events (d,m,y,data,since,length) VALUES ({0},{1},{2},'{3}',{4},{5})",
				rec.d, rec.m, rec.y, s(rec.data), n(rec.since), n(rec.length)
			);
			rec.id = Insert(sql);
			allEvents[rec.id] = rec;
			if(!events.ContainsKey(rec.d)) events[rec.d] = new List<EventRecord>();
			var src = events[rec.d];
			src.Add(rec);
			src.Sort((a,b)=>a.since.CompareTo(b.since));
		}
		
		public static void deleteEvent(int id) {
			if(!opened) return;
			string sql = String.Format("DELETE FROM events WHERE rowid={0}", id);
			Save(sql);
			var rec = allEvents[id];
			events[rec.d].Remove(rec);
			allEvents.Remove(id);
		}
		
		public static void updateActivity(ActivityRecord rec) {
			if(!opened) return;
			string sql = String.Format("UPDATE activities SET dEnd={0}, mEnd={1}, yEnd={2}, days={3}, data='{4}' WHERE rowid={5}",
				rec.dEnd, rec.mEnd, rec.yEnd, rec.days, s(rec.data), rec.id
			);	                           
			Save(sql);
			activities[rec.id] = rec;
		}

		public static void insertActivity(ActivityRecord rec) {
			if(!opened) return;
			string sql = String.Format("INSERT INTO activities (d,m,y,dEnd,mEnd,Yend,days,data) VALUES ({0},{1},{2},{3},{4},{5},{6},'{7}')",
				rec.d, rec.m, rec.y, rec.dEnd, rec.mEnd, rec.yEnd, rec.days, s(rec.data)
			);
			rec.id = Insert(sql);
			activities[rec.id] = rec;
		}

		public static void deleteActivity(int id) {
			if(!opened) return;
			string sql = String.Format("DELETE FROM activities WHERE rowid={0}", id);
			Save(sql);
			activities.Remove(id);
		}

		public static void setActivityData(ActivityDataRecord rec) {
			if(!opened) return;
			string sql;
			if(rec.id==0) {
				sql = String.Format("INSERT INTO activitiesData (activityId,d,m,y,memo) VALUES ({0},{1},{2},{3},'{4}')",
						rec.activityId, rec.d, rec.m, rec.y, s(rec.memo));
				rec.id = Insert(sql);
				activitiesData.Add(rec);
			}
			else {
				sql = String.Format("UPDATE activitiesData SET memo='{0}' WHERE id={1}", s(rec.memo), rec.id);
				Save(sql);
				var index = activitiesData.FindIndex(i=>i.id==rec.id);
				activitiesData[index].memo = rec.memo;
			}
		}

		public static void unsetActivityData(ActivityDataRecord rec) {
			if(!opened || rec.id==0) return;
			string sql = String.Format("DELETE FROM activitiesData WHERE rowid={0}", rec.id);
			Save(sql);
			activitiesData.Remove(rec);
		}
		
		public static void updateContact(ContactRecord rec) {
			if(!opened) return;
			string sql = String.Format("UPDATE contacts SET name='{0}', contact='{1}' WHERE rowid={2}",
				s(rec.name), s(rec.contact), rec.id
			);
			Save(sql);
			contacts[rec.id] = rec;
		}
		
		public static void insertContact(ContactRecord rec) {
			if(!opened) return;
			string sql = String.Format("INSERT INTO contacts (name, contact) VALUES ('{0}','{1}')",
				s(rec.name), s(rec.contact)
			);
			rec.id = Insert(sql);
			contacts[rec.id] = rec;
		}
		
		public static void deleteContact(int id) {
			if(!opened) return;
			string sql = String.Format("DELETE FROM contacts WHERE rowid={0}", id);
			Save(sql);
			contacts.Remove(id);
		}
		
		public static ActivityRecord[] NonActivities() {
			var filter = from ac in activities.Values
				where ac.days==0
				orderby ac.data ascending
				select ac;
			return filter.ToArray();
		}
		
		public static ActivityDataRecord[] ActivityNotes(int activityId) {
			var filter = from ad in activitiesData
				where ad.activityId==activityId
				orderby ad.y descending, ad.m descending, ad.d descending
				select ad;
			return filter.ToArray();
		}
	}
}
