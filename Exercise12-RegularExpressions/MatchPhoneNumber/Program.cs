using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
	static void Main()
	{
	    string pattern = @"(?:\+359)( |-)[2]\1\d{3}\1\d{4}\b";
	    string input = Console.ReadLine();
	    MatchCollection matches = Regex.Matches(input, pattern);
	    List<Match> phoneNumbers = matches.Cast<Match>().ToList();
	    Console.WriteLine(String.Join(", ", phoneNumbers));
	}
    }
}