using System;

namespace HolidayCal
{
	static class DateTimeExtensions
	{
		public static bool EqualsDay(this DateTime @this, DateTime that)
		{
			return @this.DayOfYear == that.DayOfYear;
		}
	}
}