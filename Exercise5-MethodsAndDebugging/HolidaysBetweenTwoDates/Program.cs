using System;
using System.Globalization;

namespace HolidaysBetweenTwoDates
{
	class Program
	{
		static int CountHolidaysBetween(DateTime startDate, DateTime endDate)
		{
			int holidaysCount = 0;
			for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
				if (date.DayOfWeek == DayOfWeek.Saturday ||
					date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
			return holidaysCount;
		}

		static void Main(string[] args)
		{
			DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
			DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
			Console.WriteLine(CountHolidaysBetween(startDate, endDate));
		}
	}
}