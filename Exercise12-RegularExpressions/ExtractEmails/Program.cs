using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
	static void Main()
	{
	    string pattern = @"(?:\s|^)([a-zA-Z0-9]+[\w.-]?[a-zA-Z0-9]*)\@([a-zA-Z]+\-?[a-zA-Z]+)(\.[a-zA-Z]+)+";
	    string input = Console.ReadLine();
	    MatchCollection matches = Regex.Matches(input, pattern);
	    foreach (Match email in matches)
		Console.WriteLine(email.ToString().Trim());
	}
    }
}