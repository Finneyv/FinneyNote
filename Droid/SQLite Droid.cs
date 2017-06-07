using System;
using System.IO;
using FinneyNote.Droid;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(SQLite_Droid))]
namespace FinneyNote.Droid
{
	public class SQLite_Droid : ISQlite
	{
		public SQLite_Droid()
		{
		}
		public SQLiteConnection GetConnection()
		{
			var sqliteFilename = "FinneyNote.db";
			string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			//string libraryPath = Path.Combine(documentsPath, "..", "Library");
			var path = Path.Combine(documentsPath, sqliteFilename);
			File.Open(path, FileMode.OpenOrCreate);
			var conn = new SQLiteConnection(path);
			return conn;
		}
	}
}

