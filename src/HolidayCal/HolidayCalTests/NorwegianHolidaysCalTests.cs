using System;

using HolidayCal;
using FluentAssertions;

using NUnit.Framework;
using System.Collections.Generic;

namespace HolidayCalTests
{
	class NorwegianHolidaysCalTests
	{
		public static HashSet<DateTime> Holidays()
		{
			return new HashSet<DateTime>{
				// 2010
				new DateTime(2010, 1, 1), // Nyttårsdag
				new DateTime(2010, 3, 28), // Palmesøndag
				new DateTime(2010, 4, 1), // Skjærtorsdag
				new DateTime(2010, 4, 2), // Langfredag
				new DateTime(2010, 4, 4), // 1.påskedag
				new DateTime(2010, 4, 5), // 2.påskedag
				new DateTime(2010, 5, 1), // Off. høgtidsdag
				new DateTime(2010, 5, 13), // Kristi himmelfartsdag
				new DateTime(2010, 5, 17), // Grunnlovsdag
				new DateTime(2010, 5, 23), // 1.pinsedag
				new DateTime(2010, 5, 24), // 2.pinsedag
				new DateTime(2010, 12, 25), // 1.juledag
				new DateTime(2010, 12, 26), // 2.juledag

				// 2011
				new DateTime(2011, 1, 1), // Nyttårsdag
				new DateTime(2011, 4, 17), // Palmesøndag
				new DateTime(2011, 4, 21), // Skjærtorsdag
				new DateTime(2011, 4, 22), // Langfredag
				new DateTime(2011, 4, 24), // 1.påskedag
				new DateTime(2011, 4, 25), // 2.påskedag
				new DateTime(2011, 5, 1), // Off. høgtidsdag
				new DateTime(2011, 6, 2), // Kristi himmelfartsdag
				new DateTime(2011, 5, 17), // Grunnlovsdag
				new DateTime(2011, 6, 12), // 1.pinsedag
				new DateTime(2011, 6, 13), // 2.pinsedag
				new DateTime(2011, 12, 25), // 1.juledag
				new DateTime(2011, 12, 26), // 2.juledag
			};
		}

		[TestFixture]
		public class IsHoliday
		{
			private NorwegianCal _target;

			[SetUp]
			public void Init()
			{
				_target = new NorwegianCal();
			}

			[Test]
			public void TestHolidays()
			{
				var from = new DateTime(2010, 1, 1);
				var to = new DateTime(2012, 1, 1);

				foreach (var dateTime in Days(from, to))
				{
					var isHoliday = _target.IsHoliday(dateTime);

					if(Holidays().Contains(dateTime))
						isHoliday.Should().BeTrue(string.Format("{0} should be a holiday", dateTime.ToShortDateString()));
					else
						isHoliday.Should().BeFalse(string.Format("{0} should not be a holiday", dateTime.ToShortDateString()));
				}
			}

			IEnumerable<DateTime> Days(DateTime from, DateTime to)
			{
				while (from < to)
				{
					yield return from;

					from = from.AddDays(1);
				}
			}
		}
	}
}
