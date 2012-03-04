using System;
using System.Collections.Generic;

using FluentAssertions;

using HolidayCal;

using NUnit.Framework;

namespace HolidayCalTests
{
	internal abstract class HolidayCalendarTestsBase
	{
		[Test]
		public void TestHolidays()
		{
			TestSample testSample = GetTestSample();

			foreach (DateTime date in GetDays(testSample.From, testSample.To))
			{
				Holiday holiday = GetTarget().GetHoliday(date);
				bool isHoliday = GetTarget().IsHoliday(date);

				if (testSample.Holidays.Contains(date))
				{
					holiday.Should().NotBeNull(string.Format("{0} should be a holiday", date.ToShortDateString()));
					isHoliday.Should().BeTrue();
				}
				else
				{
					holiday.Should().BeNull(string.Format("{0} should not be a holiday", date.ToShortDateString()));
					isHoliday.Should().BeFalse();
				}
			}
		}

		protected abstract IHolidayCalendar GetTarget();

		protected abstract TestSample GetTestSample();

		private static IEnumerable<DateTime> GetDays(DateTime from, DateTime to)
		{
			while (from < to)
			{
				yield return from;

				from = from.AddDays(1);
			}
		}
	}
}