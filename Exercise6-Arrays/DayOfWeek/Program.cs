using System;

namespace DayOfWeek
{
    class Program
    {
	static void Main()
	{
	    string[] dayOfWeek = {"Invalid Day!", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
	    int dayNumber = int.Parse(Console.ReadLine());
	    if (dayNumber >= 1 && dayNumber <= 7) Console.WriteLine(dayOfWeek[dayNumber]);
	    else Console.WriteLine(dayOfWeek[0]);
	}
    }
}