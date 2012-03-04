using System;

namespace HolidayCal
{
	internal static class CommonHolidays
	{
		public static Holiday AscensionDay(DateTime date)
		{
			return GetAscensionDayOfYear(date.Year).EqualsDay(date)
			       	? new Holiday(date, "Ascension day")
			       	: null;
		}

		public static Holiday EasterMonday(DateTime date)
		{
			return GetEasterMondayOfYear(date.Year).EqualsDay(date)
			       	? new Holiday(date, "Easter Monday")
			       	: null;
		}

		public static Holiday EasterSunday(DateTime date)
		{
			return GetEasterSundayOfYear(date.Year).EqualsDay(date)
			       	? new Holiday(date, "Easter Sunday")
			       	: null;
		}

		public static Holiday FirstDayOfChristmas(DateTime date)
		{
			return GetFirstDayOfChristmasOfYear(date.Year).EqualsDay(date)
			       	? new Holiday(date, "First day of Christmas")
			       	: null;
		}

		public static Holiday GoodFriday(DateTime date)
		{
			return GetGoodFridayOfYear(date.Year).EqualsDay(date)
			       	? new Holiday(date, "Good Friday")
			       	: null;
		}

		public static Holiday InternationalWorkersDay(DateTime date)
		{
			return GetInternationalWorkersDayOfYear(date.Year).EqualsDay(date)
			       	? new Holiday(date, "International Workers day")
			       	: null;
		}

		public static Holiday MaundyThursday(DateTime date)
		{
			return GetMaundyThursdayOfYear(date.Year).EqualsDay(date)
			       	? new Holiday(date, "Maundy Thursday")
			       	: null;
		}

		public static Holiday NewYearsDay(DateTime date)
		{
			return GetNewYearsDayOfYear(date.Year).EqualsDay(date)
			       	? new Holiday(date, "New Years Day")
			       	: null;
		}

		public static Holiday PalmSunday(DateTime date)
		{
			return GetPalmSundayOfYear(date.Year).EqualsDay(date)
			       	? new Holiday(date, "Palm Sunday")
			       	: null;
		}

		public static Holiday SecondDayOfChristmas(DateTime date)
		{
			return GetSecondDayOfChristmasOfYear(date.Year).EqualsDay(date)
			       	? new Holiday(date, "Second day of Christmas")
			       	: null;
		}

		public static Holiday WhitMonday(DateTime date)
		{
			return GetWhitMondayOfYear(date.Year).EqualsDay(date)
			       	? new Holiday(date, "Whit Monday")
			       	: null;
		}

		public static Holiday WhitSunday(DateTime date)
		{
			return GetWhitSundayOfYear(date.Year).EqualsDay(date)
			       	? new Holiday(date, "Whit Sunday")
			       	: null;
		}

		private static DateTime GetAscensionDayOfYear(int year)
		{
			return GetEasterSundayOfYear(year).AddDays(39);
		}

		private static DateTime GetEasterMondayOfYear(int year)
		{
			return GetEasterSundayOfYear(year).AddDays(1);
		}

		/// <summary>
		/// Easter sunday algorithm taken from http://bloggingabout.net/blogs/jschreuder/archive/2005/06/24/7019.aspx 
		/// and modified to return DateTime instead of ref input parameters
		/// </summary>
		private static DateTime GetEasterSundayOfYear(int year)
		{
			int g = year % 19;
			int c = year / 100;
			int h = (c - c / 4 - (8 * c + 13) / 25 + 19 * g + 15) % 30;
			int i = h - h / 28 * (1 - h / 28 * (29 / (h + 1)) * ((21 - g) / 11));

			int day = i - ((year + year / 4 + i + 2 - c + c / 4) % 7) + 28;
			int month = 3;

			if (day > 31)
			{
				month++;
				day -= 31;
			}

			return new DateTime(year, month, day);
		}

		private static DateTime GetFirstDayOfChristmasOfYear(int year)
		{
			return new DateTime(year, 12, 25);
		}

		private static DateTime GetGoodFridayOfYear(int year)
		{
			return GetEasterSundayOfYear(year).Subtract(TimeSpan.FromDays(2));
		}

		private static DateTime GetInternationalWorkersDayOfYear(int year)
		{
			return new DateTime(year, 5, 1);
		}

		private static DateTime GetMaundyThursdayOfYear(int year)
		{
			return GetEasterSundayOfYear(year).Subtract(TimeSpan.FromDays(3));
		}

		private static DateTime GetNewYearsDayOfYear(int year)
		{
			return new DateTime(year, 1, 1);
		}

		private static DateTime GetPalmSundayOfYear(int year)
		{
			return GetEasterSundayOfYear(year).Subtract(TimeSpan.FromDays(7));
		}

		private static DateTime GetSecondDayOfChristmasOfYear(int year)
		{
			return GetFirstDayOfChristmasOfYear(year).AddDays(1);
		}

		private static DateTime GetWhitMondayOfYear(int year)
		{
			return GetWhitSundayOfYear(year).AddDays(1);
		}

		private static DateTime GetWhitSundayOfYear(int year)
		{
			return GetEasterSundayOfYear(year).AddDays(49);
		}
	}
}