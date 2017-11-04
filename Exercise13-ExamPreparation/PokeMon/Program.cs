using System;

namespace PokeMon
{
    class Program
    {
	static void Main()
	{
	    int initialPower = int.Parse(Console.ReadLine());
	    int distance = int.Parse(Console.ReadLine());
	    int fatigue = int.Parse(Console.ReadLine());
	    int pokes = 0;
	    int remainingPower = initialPower;
	    while (remainingPower >= distance)
	    {
		remainingPower -= distance;
		pokes++;
		if ((double)initialPower / remainingPower == 2)
		    if(fatigue != 0)
			remainingPower /= fatigue;
	    }
	    Console.WriteLine(remainingPower);
	    Console.WriteLine(pokes);
	}
    }
}