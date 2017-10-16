using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter
{
    class Program
    {
	static void Main()
	{
	    Dictionary<string/*country*/, Dictionary<string/*city*/, long/*population*/>> census =
		new Dictionary<string, Dictionary<string, long>>();
	    string[] input = Console.ReadLine()
		.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
		.ToArray();
	    while (input[0].ToUpper() != "REPORT")
	    {
		string city = input[0];
		string country = input[1];
		int population = int.Parse(input[2]);
		if (!census.ContainsKey(country))
		{
		    census.Add(country, new Dictionary<string, long>());
		    census[country].Add(city, population);
		}
		else
		{
		    if (!census[country].ContainsKey(city)) census[country].Add(city, population);
		}
		input = Console.ReadLine()
		.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
		.ToArray();
	    }
	    foreach (var country in census.OrderByDescending(country => country.Value.Values.Sum()))
	    {
		Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
		foreach (var city in country.Value.OrderByDescending(city => city.Value))
		{
		    Console.WriteLine($"=>{city.Key}: {city.Value}");
		}
	    }
	}
    }
}