using System;
using WebKit;
using System.IO;
using FinneyNote.iOS;

[assembly:Xamarin.Forms.Dependency(typeof(SQLite_iOS))]
namespace FinneyNote.iOS
{
	public class SQLite_iOS : ISQlite
	{
		public SQLite_iOS ()
		{
		}
		public SQLite.SQLiteConnection GetConnection()
		{
			//path for iOS here
			var sqliteFilename = "FinneyNote.db";
			string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string libraryPath = Path.Combine (documentsPath, "..", "Library");
			var path = Path.Combine (libraryPath, sqliteFilename);
			//var path = "/Users/victorfinney/Documents/FinneyNote.db";
			File.Open (path, FileMode.OpenOrCreate);
			var conn = new SQLite.SQLiteConnection (path);
			return conn;
		}
	}
}

