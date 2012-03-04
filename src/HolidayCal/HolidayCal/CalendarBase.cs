using System;

namespace HolidayCal
{
	public abstract class CalendarBase : IHolidayCalendar
	{
		public abstract Holiday GetHoliday(DateTime date);

		public bool IsHoliday(DateTime date)
		{
			return GetHoliday(date) != null;
		}
	}
}