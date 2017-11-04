using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HornetCommunication
{
    class Program
    {
	static void Main()
	{
	    List<string> messages = new List<string>();
	    List<string> broadcasts = new List<string>();
	    string patternM = @"^(\d+)\s\<\-\>\s([0-9a-z-A-Z]+)$";
	    string patternB = @"^(\D+)\s\<\-\>\s([0-9a-z-A-Z]+)$";
	    string input = Console.ReadLine();
	    while (input != "Hornet is Green")
	    {
		if (Regex.IsMatch(input, patternM))
		{
		    string recipient = String.Join("",Regex.Match(input, patternM).Groups[1].Value.Reverse());
		    string message = Regex.Match(input, patternM).Groups[2].Value;
		    messages.Add($"{recipient} -> {message}");
		}
		else if (Regex.IsMatch(input, patternB))
		{
		    string message = Regex.Match(input, patternB).Groups[1].Value;
		    string frequency = Regex.Match(input, patternB).Groups[2].Value;
		    StringBuilder sb = new StringBuilder();
		    for (int c = 0; c < frequency.Length; c++)
		    {
			if (Char.IsUpper(frequency[c])) sb.Append(Char.ToLower(frequency[c]));
			else if (Char.IsLower(frequency[c])) sb.Append(Char.ToUpper(frequency[c]));
			else sb.Append(frequency[c]);
		    }
		    frequency = sb.ToString();
		    broadcasts.Add($"{frequency} -> {message}");
		}
		input = Console.ReadLine();
	    }
	    Console.WriteLine("Broadcasts:");
	    if (broadcasts.Count() == 0) Console.WriteLine("None");
	    else
	    {
		foreach (var broadcast in broadcasts)
		    Console.WriteLine(broadcast);
	    }
	    Console.WriteLine("Messages:");
	    if (messages.Count() == 0) Console.WriteLine("None");
	    else
	    {
		foreach (var message in messages)
		    Console.WriteLine(message);
	    }
	}
    }
}