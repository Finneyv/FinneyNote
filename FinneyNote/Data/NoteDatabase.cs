using System;
using SQLite;
using Xamarin.Forms;
using System.Linq;
using System.Collections.Generic;

namespace FinneyNote
{
	public class NoteDatabase
	{
		private SQLiteConnection database;
		static object locker = new object();
		public NoteDatabase ()
		{
			database = DependencyService.Get<ISQlite>().GetConnection();
			database.CreateTable<Note> ();
		}
		public Note GetNote(int id){
			lock (locker) {
				return database.Table<Note> ().Where (c => c.ID == id).FirstOrDefault ();
			}
		}
		public int SaveNote( Note note){
			lock (locker){
				if (note.ID != 0) {
					database.Update(note);
					return note.ID;
				} else {
					return database.Insert (note);
				}
			}
		}
		public void DeleteNote(Note note){
			lock (locker) {
				database.Delete (note);
			}
		}
		public IEnumerable<Note> GetNotes(){
			lock (locker) {
				List<Note> notelist = (from c in database.Table<Note> ()select c).ToList ();
				notelist = notelist.OrderByDescending (o => o.ID).ToList ();
				return notelist;
			}
		}
	}
}

