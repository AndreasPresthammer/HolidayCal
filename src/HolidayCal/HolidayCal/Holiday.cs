using System;

namespace HolidayCal
{
	public class Holiday
	{
		public Holiday(DateTime date, string name)
		{
			Date = date;
			Name = name;
		}

		public DateTime Date { get; set; }

		public string Name { get; set; }

		public override string ToString()
		{
			return string.Format("{0} at {1}", Name, Date.ToShortDateString());
		}
	}
}