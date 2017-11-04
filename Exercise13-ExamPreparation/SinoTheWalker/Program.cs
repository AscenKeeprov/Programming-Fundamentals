using System;
using System.Globalization;

namespace SinoTheWalker
{
    class Program
    {
	static void Main()
	{
	    DateTime departure = DateTime.ParseExact(Console.ReadLine(),
		"HH:mm:ss", CultureInfo.InvariantCulture);
	    int steps = int.Parse(Console.ReadLine()) % 86400;
	    int secondsPerStep = int.Parse(Console.ReadLine()) % 86400;
	    long trip = steps * secondsPerStep;
	    DateTime arrival = departure.AddSeconds(trip);
	    Console.WriteLine($"Time Arrival: {arrival.ToString("HH:mm:ss")}");
	}
    }
}