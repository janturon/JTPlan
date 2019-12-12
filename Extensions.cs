using System;
using System.Text;
using System.Security.Cryptography;

namespace JTPlan {
	public static class Extensions	{
		public static int WeekDay(this DateTime day) {
			return (int)(day.DayOfWeek + 6) % 7;
		}
		public static int Float2Minutes(float f) {
			int i = (int)f;
			return (int)((f - i) * 60);	
		}
		public static float Time2Float(string t) {
			string[] parts = t.Split(':');
			int i = Int32.Parse(parts[0]);
			int dec = Int32.Parse(parts[1]);
			return i + dec/60F;
		}
		public static string Float2Time(float f) {
			int i = (int)f;
			int dec = Extensions.Float2Minutes(f);
			return String.Format("{0}:{1}", i, dec.ToString().PadLeft(2, '0'));
		}
		public static string SQLiteEscape(string s) {
			return s.Replace("'", "''");
		}
		public static string SQLiteFloat(float f) {
			return f.ToString().Replace(",", ".");
		}
		public static string DayInflex(int diff) {
			string prep = diff>0 ? "za " : "před ";
			string inflex = "";
			if(diff==0) inflex = "dnes!";
			else if(diff==-1) inflex = "dnem";
			else if(diff<-1) inflex = "dny";
			else if(diff==1) inflex = "den";
			else if(diff<5) inflex = "dny";
			else inflex = "dní";
			if(diff<0) diff*= -1;
			else if(diff==0) prep = "";
			string sdays = "";
			if(diff>0) sdays = diff+" ";
			return prep + sdays + inflex;
		}

		static byte[] entropy = { 3, 1, 8, 6, 4 };

		public static string Encrypt(string data) {
			byte[] bytes = Encoding.UTF8.GetBytes(data);
			byte[] encrypted = ProtectedData.Protect(bytes, entropy, DataProtectionScope.CurrentUser);
			return Convert.ToBase64String(encrypted);
	    }
	
	    public static string Decrypt(string data) {
			byte[] bytes = Convert.FromBase64String(data);
			try {
				byte[] decrypted = ProtectedData.Unprotect(bytes, entropy, DataProtectionScope.CurrentUser);
				return Encoding.UTF8.GetString(decrypted);
			}
			catch(Exception) {
				return "";
			}
	    }

	}
}
