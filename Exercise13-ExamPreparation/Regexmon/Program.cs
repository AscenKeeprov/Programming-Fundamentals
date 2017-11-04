using System;
using System.Text.RegularExpressions;

namespace Regexmon
{
    class Program
    {
	static void Main()
	{
	    string input = Console.ReadLine();
	    while (true)
	    {
		Match matchD = Regex.Match(input, @"([^-a-zA-Z]+)");
		if (!matchD.Success) break;
		Console.WriteLine(matchD);
		input = input.Remove(0, matchD.Index + matchD.Length);
		Match matchB = Regex.Match(input, @"([a-zA-Z]+\-[a-zA-Z]+)");
		if (!matchB.Success) break;
		Console.WriteLine(matchB);
		input = input.Remove(0, matchB.Index + matchB.Length);
	    }
	}
    }
}