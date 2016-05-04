using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FinneyNote
{
	public partial class CreateNotePage : ContentPage
	{
		public List<Note> NoteList = new List<Note>();
		private CreatNotePageViewModel vm;
		private int updateID = 0;
		//private Note note = new Note{};
		public CreateNotePage (int id)
		{
			vm = new CreatNotePageViewModel();
			BindingContext = vm;
			InitializeComponent ();
			Note note = App.Database.GetNote(id);
			NoteTitle.Text = note.NoteTitle;
			NoteContent.Text = note.NoteContent;
			//Date.Date = note.DateCreated;
			//Time.Time = note.DateCreated.TimeofDay;
			updateID = id;
		}

		public CreateNotePage(){
			vm = new CreatNotePageViewModel();
			BindingContext = vm;
			InitializeComponent();
		}
		public void OnSave(object o, EventArgs e)
		{
			vm.AddNote (NoteTitle.Text, NoteContent.Text, DateTime.Now, updateID, false);
			Navigation.PopAsync ();
		}
	}
}

