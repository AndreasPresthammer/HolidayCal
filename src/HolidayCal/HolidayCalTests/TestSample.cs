using System;
using System.Collections.Generic;

namespace HolidayCalTests
{
	internal class TestSample
	{
		public TestSample()
		{
			From = new DateTime(2010, 1, 1);
			To = new DateTime(2012, 1, 1);
			Holidays = new HashSet<DateTime>();
		}

		public DateTime From { get; set; }

		public HashSet<DateTime> Holidays { get; set; }

		public DateTime To { get; set; }
	}
}