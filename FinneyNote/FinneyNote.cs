using System;

using Xamarin.Forms;

namespace FinneyNote
{
	public class App : Application
	{
		private static NoteDatabase database;
		public static NoteDatabase Database
		{
			get {
				if (database == null) {
					database = new NoteDatabase ();
				}
				return database;
			}
		}
		public App ()
		{
			// The root page of your application
			MainPage = new NavigationPage(new ListNotePage ());
		}
		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

