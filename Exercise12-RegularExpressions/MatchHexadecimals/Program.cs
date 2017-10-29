using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchHexadecimals
{
    class Program
    {
	static void Main()
	{
	    string pattern = @"\b(?:0x)?[0-9A-F]+\b";
	    string input = Console.ReadLine();
	    MatchCollection matches = Regex.Matches(input, pattern);
	    List<Match> hexadecimals = matches.Cast<Match>().ToList();
	    Console.WriteLine(String.Join(" ", hexadecimals));
	}
    }
}