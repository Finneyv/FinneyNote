using System;
using SQLite;

namespace FinneyNote
{
	public class Note
	{
		[PrimaryKey, AutoIncrement]
		public int ID{ get; set; }

		public string NoteTitle{ get; set;}
		public string NoteContent{ get; set;}
		public DateTime DateCreated{ get; set;}
		public bool IsDeleted{ get; set;}
	}
}

