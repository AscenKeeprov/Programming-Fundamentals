using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SrpskoUnleashed
{
    class Program
    {
	static void Main()
	{
	    Dictionary<string/*location*/, Dictionary<string/*singer*/, uint/*profits*/>> tourLog = 
		new Dictionary<string, Dictionary<string, uint>>();
	    string input = Console.ReadLine();
	    while (input.ToUpper() != "END")
	    {
		if (Regex.IsMatch(input, @"^(.*?) @(.*?) (\d+) (\d+)$"))
		{
		    string[] poster = input.Split('@').ToArray();
		    string singer = poster[0].Trim();
		    string[] eventDetails = poster[1].Trim().Split(' ').ToArray();
		    uint ticketCount = uint.Parse(eventDetails.Last());
		    eventDetails = eventDetails.Take(eventDetails.Count() - 1).ToArray();
		    byte ticketPrice = byte.Parse(eventDetails.Last());
		    eventDetails = eventDetails.Take(eventDetails.Count() - 1).ToArray();
		    uint profits = ticketCount * ticketPrice;
		    string location = String.Join(" ", eventDetails);
		    if (!tourLog.ContainsKey(location))
		    {
			tourLog.Add(location, new Dictionary<string, uint>());
			tourLog[location].Add(singer, profits);
		    }
		    else
		    {
			if (!tourLog[location].ContainsKey(singer)) tourLog[location].Add(singer, profits);
			else tourLog[location][singer] += profits;
		    }
		    input = Console.ReadLine();
		}
		else input = Console.ReadLine();
	    }
	    foreach (var location in tourLog)
	    {
		Console.WriteLine(location.Key);
		foreach (var singer in location.Value.OrderByDescending(profits => profits.Value))
		    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
	    }
	}
    }
}