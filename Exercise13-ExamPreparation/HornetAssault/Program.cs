using System;
using System.Collections.Generic;
using System.Linq;

namespace HornetAssault
{
    class Program
    {
	static void Main()
	{
	    List<long> beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
	    List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();
	    for (int b = 0; b < beehives.Count; b++)
	    {
		long beehivePower = beehives[b];
		long hornetsPower = hornets.Sum();
		if (hornets.Count > 0)
		{
		    if (hornetsPower > beehivePower) beehives[b] = 0;
		    else
		    {
			beehives[b] -= hornetsPower;
			hornets.RemoveAt(0);
		    }
		}
		else break;
	    }
	    beehives.RemoveAll(b => b == 0);
	    if (beehives.Count > 0) Console.WriteLine(String.Join(" ", beehives));
	    else Console.WriteLine(String.Join(" ", hornets));
	}
    }
}