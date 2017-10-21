using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CountWorkingDays
{
    class Program
    {
	static void Main()
	{
	    DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
	    DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
	    List<DateTime> holidays = new List<DateTime>
	    {
		DateTime.ParseExact("01-01-1972", "dd-MM-yyyy", CultureInfo.InvariantCulture),
		DateTime.ParseExact("03-03-1972", "dd-MM-yyyy", CultureInfo.InvariantCulture),
		DateTime.ParseExact("01-05-1972", "dd-MM-yyyy", CultureInfo.InvariantCulture),
		DateTime.ParseExact("06-05-1972", "dd-MM-yyyy", CultureInfo.InvariantCulture),
		DateTime.ParseExact("24-05-1972", "dd-MM-yyyy", CultureInfo.InvariantCulture),
		DateTime.ParseExact("06-09-1972", "dd-MM-yyyy", CultureInfo.InvariantCulture),
		DateTime.ParseExact("22-09-1972", "dd-MM-yyyy", CultureInfo.InvariantCulture),
		DateTime.ParseExact("01-11-1972", "dd-MM-yyyy", CultureInfo.InvariantCulture),
		DateTime.ParseExact("24-12-1972", "dd-MM-yyyy", CultureInfo.InvariantCulture),
		DateTime.ParseExact("25-12-1972", "dd-MM-yyyy", CultureInfo.InvariantCulture),
		DateTime.ParseExact("26-12-1972", "dd-MM-yyyy", CultureInfo.InvariantCulture),
	    };
	    ushort workDays = 0;
	    for (DateTime d = startDate; d <= endDate; d = d.AddDays(1))
	    {
		if (!holidays.Any(h => h.Day == d.Day && h.Month == d.Month)
		    && d.DayOfWeek != DayOfWeek.Saturday
		    && d.DayOfWeek != DayOfWeek.Sunday)
		    workDays++;
	    }
	    Console.WriteLine(workDays);
	}
    }
}