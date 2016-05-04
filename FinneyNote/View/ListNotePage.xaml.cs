using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FinneyNote
{
	public partial class ListNotePage : ContentPage
	{
		
		public List<Note> Notes{ get; set; }
		public ListNotePage()
		{
			InitializeComponent ();
		}
		public void OnSelected(object o, ItemTappedEventArgs e)
		{
			var note = e.Item as Note;
			int id = note.ID;
			Navigation.PushAsync (new EditNotePage(id));
		}
		protected override void OnAppearing(){
			base.OnAppearing ();
			DisplayedNotes.ItemsSource = App.Database.GetNotes();
		}
		public void OnAddNote(object o, EventArgs e){
			Navigation.PushAsync (new CreateNotePage ());
		}
	}
}

