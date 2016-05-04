using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FinneyNote
{
	public class CreatNotePageViewModel
	{
		public CreatNotePageViewModel ()
		{
		}
		public void AddNote(string title, string content, DateTime date, int updateID, bool isDeleted){
			var newNote = new Note{NoteTitle = title, NoteContent = content, DateCreated = date, IsDeleted = isDeleted, ID = updateID};
			if(newNote.NoteTitle != null){
				App.Database.SaveNote (newNote);
			}
		}
		public void UpdateNote(string title, string content, DateTime date, int updateID, bool isDeleted){
			var oldNote = App.Database.GetNote(updateID);
			App.Database.DeleteNote(oldNote);
			var newNote = new Note{NoteTitle = title, NoteContent = content, DateCreated = date, IsDeleted = isDeleted, ID = updateID};
			App.Database.SaveNote (newNote);
		}
		public void DeleteNote(int updateID){
			var oldNote = App.Database.GetNote(updateID);
			if (oldNote != null) {
				oldNote.IsDeleted = true;
				App.Database.DeleteNote (oldNote);
			}
		}
	}
}