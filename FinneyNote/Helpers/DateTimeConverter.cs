using System;
using Xamarin.Forms;

namespace FinneyNote
{
	public class DateTimeConverter : IValueConverter
	{
		public DateTimeConverter (){}
		#region IValueConverter implementation

		public object Convert (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			var creationDate = (DateTime)value;
			return creationDate.ToString("M/dd/yyyy");
		}

		public object ConvertBack (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException ();
		}

		#endregion

	}
}

