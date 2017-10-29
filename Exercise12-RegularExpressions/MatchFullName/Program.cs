using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
	static void Main()
	{
	    string pattern = @"\b[A-Z][a-z]+\b \b[A-Z][a-z]+\b";
	    string input = Console.ReadLine();
	    MatchCollection names = Regex.Matches(input, pattern);
	    foreach (Match name in names)
		Console.Write($"{name} ");
	    Console.WriteLine();
	}
    }
}