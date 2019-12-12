using System;
using System.Net;
using System.IO;

namespace JTPlan {
	public class Remote {
		public string server, login, password, dbName;
		public Remote(string server, string login, string password, string dbName) {
			this.server = server;
			this.login = login;
			this.password = password;
			this.dbName = dbName;
		}
		
		public Remote() {
		}
		
		FtpWebRequest CreateRequest() {
			var req = WebRequest.Create("ftp://"+server+"/"+dbName) as FtpWebRequest;
			req.Credentials = new NetworkCredential(login, password);
			req.UseBinary = true;
			req.UsePassive = true;
			return req;
		}
		
		public bool DownloadDB(string suffix="") {
			var client = new WebClient();
			client.Credentials = new NetworkCredential(login, password);
			try {
				if(File.Exists(dbName+suffix)) File.Delete(dbName+suffix);
				client.DownloadFile("ftp://"+server+"/"+dbName, dbName+suffix);
			}
			catch(Exception) { return false; }
			return true;
		}
		
		public bool UploadDB() {
			var client = new WebClient();
			client.Credentials = new NetworkCredential(login, password);
			try { client.UploadFile("ftp://"+server+"/"+dbName, WebRequestMethods.Ftp.UploadFile, dbName); }
			catch(Exception) { return false; }
			return true;
		}
		
		public DateTime? GetDBDate() {
			var req = CreateRequest();
			req.Method = WebRequestMethods.Ftp.GetDateTimestamp;
			try {
				var res = req.GetResponse() as FtpWebResponse;
				return res.LastModified;
			}
			catch(Exception) { return null; }
		}

		public void ReplaceDBWith(string suffix) {
			File.Delete(dbName);
			File.Move(dbName+suffix, dbName);
		}		

	}
}
