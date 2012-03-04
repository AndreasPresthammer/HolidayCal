using System;

namespace HolidayCal
{
	public interface IHolidayCalendar
	{
		Holiday GetHoliday(DateTime date);

		bool IsHoliday(DateTime date);
	}
}