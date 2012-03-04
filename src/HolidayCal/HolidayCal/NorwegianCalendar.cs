using System;

namespace HolidayCal
{
	public class NorwegianCalendar : CalendarBase
	{
		public override Holiday GetHoliday(DateTime date)
		{
			return
				CommonHolidays.NewYearsDay(date) ??
				CommonHolidays.PalmSunday(date) ??
				CommonHolidays.MaundyThursday(date) ??
				CommonHolidays.GoodFriday(date) ??
				CommonHolidays.EasterSunday(date) ??
				CommonHolidays.EasterMonday(date) ??
				CommonHolidays.InternationalWorkersDay(date) ??
				CommonHolidays.AscensionDay(date) ??
				NorwegianConstitutionDay(date) ??
				CommonHolidays.WhitSunday(date) ??
				CommonHolidays.WhitMonday(date) ??
				CommonHolidays.FirstDayOfChristmas(date) ??
				CommonHolidays.SecondDayOfChristmas(date);
		}

		private static DateTime GetNorwegianConstitutionDayOfYear(int year)
		{
			return new DateTime(year, 5, 17);
		}

		private static Holiday NorwegianConstitutionDay(DateTime date)
		{
			return GetNorwegianConstitutionDayOfYear(date.Year).EqualsDay(date)
			       	? new Holiday(date, "Norwegian constitution day")
			       	: null;
		}
	}
}