using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDoNotGo
{
    class Program
    {
	static void Main()
	{
	    List<int> distances = Console.ReadLine()
		.Split().Select(int.Parse).ToList();
	    int position = int.Parse(Console.ReadLine());
	    int element = 0;
	    long sumElements = 0;
	    while (distances.Count > 0)
	    {
		if (position < 0)
		{
		    element = distances.First();
		    distances[0] = distances.Last();
		}
		else if (position >= distances.Count)
		{
		    element = distances.Last();
		    distances[distances.Count - 1] = distances.First();
		}
		else element = distances[position];
		for (int i = 0; i < distances.Count; i++)
		{
		    if (distances[i] <= element) distances[i] += element;
		    else if (distances[i] > element) distances[i] -= element;
		}
		sumElements += element;
		if (position >= 0 && position < distances.Count)
		    distances.RemoveAt(position);
		if (distances.Count == 0) break;
		position = int.Parse(Console.ReadLine());
	    }
	    Console.WriteLine(sumElements);
	}
    }
}