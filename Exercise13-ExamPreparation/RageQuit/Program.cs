using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RageQuit
{
    class Program
    {
	static void Main()
	{
	    string input = Console.ReadLine().ToUpper();
	    MatchCollection strings = Regex.Matches(input, @"(\D+)");
	    MatchCollection counts = Regex.Matches(input, @"(\d+)");
	    StringBuilder message = new StringBuilder();
	    for (int i = 0; i < strings.Count; i++)
		message.Insert(message.Length, strings[i].Value, int.Parse(counts[i].Value));
	    int symbols = message.ToString().Distinct().Count();
	    Console.WriteLine($"Unique symbols used: {symbols}");
	    Console.WriteLine(message);
	}
    }
}