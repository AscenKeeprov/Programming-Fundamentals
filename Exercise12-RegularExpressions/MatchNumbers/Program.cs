using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchNumbers
{
    class Program
    {
	static void Main()
	{
	    string pattern = @"(^|(?<=\s))\-?\d+(\.\d+)?($|(?=\s))";
	    string input = Console.ReadLine();
	    MatchCollection matches = Regex.Matches(input, pattern);
	    List<Match> numbers = matches.Cast<Match>().ToList();
	    Console.WriteLine(String.Join(" ", numbers));
	}
    }
}