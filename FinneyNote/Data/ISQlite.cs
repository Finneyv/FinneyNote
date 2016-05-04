using System;
using SQLite;

namespace FinneyNote
{
	public interface ISQlite
	{
		SQLiteConnection GetConnection();
	}
}

