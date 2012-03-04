using System;
using System.Collections.Generic;

using HolidayCal;

namespace HolidayCalTests
{
	internal class NorwegianCalendarTests : HolidayCalendarTestsBase
	{
		protected override IHolidayCalendar GetTarget()
		{
			return new NorwegianCalendar();
		}

		protected override TestSample GetTestSample()
		{
			return new TestSample
				{
					Holidays = new HashSet<DateTime>
						{
							// 2010
							SampleHoliday.NewYearsDay2010,
							SampleHoliday.PalmSunday2010,
							SampleHoliday.MaundyThursday2010,
							SampleHoliday.GoodFriday2010,
							SampleHoliday.EasterSunday2010,
							SampleHoliday.EasterMonday2010,
							SampleHoliday.InternationalWorkersDay2010,
							SampleHoliday.AscensionDay2010,
							SampleHoliday.NorwegianConstitutionDay2010,
							SampleHoliday.WhitSunday2010,
							SampleHoliday.WhitMonday2010,
							SampleHoliday.FirstDayOfChristmas2010,
							SampleHoliday.SecondDayOfChristmas2010,
							// 2011
							SampleHoliday.NewYearsDay2011,
							SampleHoliday.PalmSunday2011,
							SampleHoliday.MaundyThursday2011,
							SampleHoliday.GoodFriday2011,
							SampleHoliday.EasterSunday2011,
							SampleHoliday.EasterMonday2011,
							SampleHoliday.InternationalWorkersDay2011,
							SampleHoliday.AscensionDay2011,
							SampleHoliday.NorwegianConstitutionDay2011,
							SampleHoliday.WhitSunday2011,
							SampleHoliday.WhitMonday2011,
							SampleHoliday.FirstDayOfChristmas2011,
							SampleHoliday.SecondDayOfChristmas2011
						}
				};
		}
	}
}