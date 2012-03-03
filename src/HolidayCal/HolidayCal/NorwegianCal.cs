using System;

namespace HolidayCal
{
	public class NorwegianCal
	{
		public bool IsHoliday(DateTime date)
		{
			return
				IsNewYearsDay(date) ||
				IsPalmSunday(date) ||
				IsMaundyThursday(date) ||
				IsGoodFriday(date) ||
				IsEasterSunday(date) ||
				IsEasterMonday(date) ||
				IsInternationalWorkersDay(date) ||
				IsAscensionDay(date) || 
				IsNorwegianConstitutionDay(date) ||
				IsWhitSunday(date) ||
				IsWhitMonday(date) ||
				IsFirstDayOfChristmas(date) ||
				IsSecondDayOfChristmas(date);
		}

		private bool IsSecondDayOfChristmas(DateTime date)
		{
			return GetSecondDayOfChristmas(date.Year).DayOfYear == date.DayOfYear;
		}

		private DateTime GetSecondDayOfChristmas(int year)
		{
			return GetFirstDayOfChristmas(year).AddDays(1);
		}

		private bool IsFirstDayOfChristmas(DateTime date)
		{
			return GetFirstDayOfChristmas(date.Year).DayOfYear == date.DayOfYear;
		}

		private DateTime GetFirstDayOfChristmas(int year)
		{
			return new DateTime(year, 12, 25);
		}

		private bool IsWhitMonday(DateTime date)
		{
			return GetWhiteMonday(date).DayOfYear == date.DayOfYear;
		}

		private DateTime GetWhiteMonday(DateTime date)
		{
			return GetWhiteSunday(date.Year).AddDays(1);
		}

		private bool IsWhitSunday(DateTime date)
		{
			return GetWhiteSunday(date.Year).DayOfYear == date.DayOfYear;
		}

		private DateTime GetWhiteSunday(int year)
		{
			return GetEasterSunday(year).AddDays(49);
		}

		private bool IsNorwegianConstitutionDay(DateTime date)
		{
			return GetNorwegianConstitutionDay(date.Year).DayOfYear == date.DayOfYear;
		}

		private DateTime GetNorwegianConstitutionDay(int year)
		{
			return new DateTime(year, 5, 17);
		}

		private bool IsAscensionDay(DateTime date)
		{
			return GetAscensionDay(date.Year).DayOfYear == date.DayOfYear;
		}

		private DateTime GetAscensionDay(int year)
		{
			return GetEasterSunday(year).AddDays(39);
		}

		private bool IsInternationalWorkersDay(DateTime date)
		{
			return GetInternationalWorkersDay(date.Year).DayOfYear == date.DayOfYear;
		}

		private DateTime GetInternationalWorkersDay(int year)
		{
			return new DateTime(year, 5, 1);
		}

		private bool IsEasterMonday(DateTime date)
		{
			return GetEasterMonday(date.Year).DayOfYear == date.DayOfYear;
		}

		private DateTime GetEasterMonday(int year)
		{
			return GetEasterSunday(year).AddDays(1);
		}

		private bool IsEasterSunday(DateTime date)
		{
			return GetEasterSunday(date.Year).DayOfYear == date.DayOfYear;
		}

		private bool IsGoodFriday(DateTime date)
		{
			return GetGoodFriday(date.Year).DayOfYear == date.DayOfYear;
		}

		private DateTime GetGoodFriday(int year)
		{
			return GetEasterSunday(year).Subtract(TimeSpan.FromDays(2));
		}

		private bool IsPalmSunday(DateTime date)
		{
			return GetPalmSunday(date.Year).DayOfYear == date.DayOfYear;
		}

		private DateTime GetPalmSunday(int year)
		{
			return GetEasterSunday(year).Subtract(TimeSpan.FromDays(7));
		}

		/// <summary>
		/// Easter algorithm taken from http://bloggingabout.net/blogs/jschreuder/archive/2005/06/24/7019.aspx 
		/// and modified to return DateTime instead of ref input parameters
		/// </summary>
		private DateTime GetEasterSunday(int year)
		{
			if (year < 1 || year > 9999) 
				throw new ArgumentOutOfRangeException("year", year, "Must be between 0001 and 9999.");

			var g = year % 19;
			var c = year / 100;
			var h = (c - c / 4 - (8 * c + 13) / 25 + 19 * g + 15) % 30;
			var i = h - h / 28 * (1 - h / 28 * (29 / (h + 1)) * ((21 - g) / 11));

			var day = i - ((year + year / 4 + i + 2 - c + c / 4) % 7) + 28;
			var month = 3;

			if (day > 31)
			{
				month++;
				day -= 31;
			}

			return new DateTime(year, month, day);
		}

		private bool IsMaundyThursday(DateTime date)
		{
			return GetMaundyThursday(date.Year).DayOfYear == date.DayOfYear;
		}

		private DateTime GetMaundyThursday(int year)
		{
			return GetEasterSunday(year).Subtract(TimeSpan.FromDays(3));
		}

		private bool IsNewYearsDay(DateTime date)
		{
			return GetNewYearsDay(date.Year).DayOfYear == date.DayOfYear;
		}

		private DateTime GetNewYearsDay(int year)
		{
			return new DateTime(year, 1, 1);
		}
	}
}
