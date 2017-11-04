using System;
using System.Collections.Generic;
using System.Linq;

namespace EnduranceRally
{
    class Program
    {
	static void Main()
	{
	    List<string> standings = new List<string>();
	    List<string> drivers = Console.ReadLine().Split().ToList();
	    double[] track = Console.ReadLine().Split().Select(double.Parse).ToArray();
	    int[] checkpoints = Console.ReadLine().Split().Select(int.Parse).ToArray();
	    for (int z = 0; z < track.Length; z++)
		if (!checkpoints.Any(c => c == z)) track[z] *= -1;
	    foreach (string driver in drivers)
	    {
		double fuel = driver.First();
		for (int z = 0; z < track.Length; z++)
		{
		    fuel += track[z];
		    if (fuel <= 0)
		    {
			standings.Add($"{driver} - reached {z}");
			break;
		    }
		    else if (z == track.Length - 1)
			standings.Add($"{driver} - fuel left {fuel:F2}");
		}
	    }
	    foreach (var driver in standings) Console.WriteLine(driver);
	}
    }
}