using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniKaraoke
{
    class Program
    {
	static void Main()
	{
	    Dictionary<string, List<string>> standings = new Dictionary<string, List<string>>();
	    List<string> participants = Console.ReadLine()
		.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
		.ToList();
	    List<string> songs = Console.ReadLine()
		.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
		.ToList();
	    string[] performance = Console.ReadLine()
		.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
	    while (performance[0].ToUpper() != "DAWN")
	    {
		string participant = performance[0];
		string song = performance[1];
		if (participants.Contains(participant) && songs.Contains(song))
		{
		    if (!standings.ContainsKey(participant))
			standings.Add(participant, new List<string>());
		    string award = performance[2];
		    if (!standings[participant].Contains(award))
			standings[participant].Add(award);
		}
		performance = Console.ReadLine()
		.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
	    }
	    bool fiasco = true;
	    foreach (var participant in standings
		.OrderByDescending(p => p.Value.Count).ThenBy(p => p.Key))
	    {
		Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");
		foreach (var award in participant.Value.OrderBy(a => a))
		    Console.WriteLine($"--{award}");
		if (participant.Value.Count > 0) fiasco = false;
	    }
	    if (fiasco == true) Console.WriteLine("No awards");
	}
    }
}