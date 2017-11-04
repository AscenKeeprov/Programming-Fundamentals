using System;

namespace HornetWings
{
    class Program
    {
	static void Main()
	{
	    int flaps = int.Parse(Console.ReadLine());
	    double distancePerFlap = double.Parse(Console.ReadLine()) / 1000;
	    int endurance = int.Parse(Console.ReadLine());
	    int flapsPerSecond = 100;
	    double distanceTotal = distancePerFlap * flaps;
	    int rests = (int)(Math.Ceiling((double)flaps / endurance) - 1);
	    double secondsNeeded = ((double)flaps / flapsPerSecond) + rests * 5;
	    Console.WriteLine($"{distanceTotal:F2} m.");
	    Console.WriteLine($"{secondsNeeded:F0} s.");
	}
    }
}