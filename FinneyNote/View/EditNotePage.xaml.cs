using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FinneyNote
{
	public partial class EditNotePage : ContentPage
	{
		private CreatNotePageViewModel vm;
		private int ID = 0;
		private DateTime date;
		public EditNotePage (int id)
		{
			vm = new CreatNotePageViewModel ();
			BindingContext = vm;
			InitializeComponent ();
			Note note = App.Database.GetNote(id);
			NoteTitleEdit.Text = note.NoteTitle;
			NoteContentEdit.Text = note.NoteContent;
			DateCreatedEdit.Text = note.DateCreated.ToString("M-dd-yyyy h:mm tt");
			ID = id;
			date = note.DateCreated;
		}
		public void OnSave(object o, EventArgs e){
			vm.AddNote (NoteTitleEdit.Text, NoteContentEdit.Text, date, ID, false);
			Navigation.PopAsync ();
		}
		public void OnDelete(object o, EventArgs e){
			vm.DeleteNote (ID);
			Navigation.PopAsync ();
		}
		/*public void OnEntryTextChanged(object o, EventArgs e){
			String val = NoteTitleEdit.Text;
			if (val.Length > 30) {
				val = val.Remove (val.Length - 1);
				NoteTitleEdit.Text = val;
			}
		}*/
	}
}