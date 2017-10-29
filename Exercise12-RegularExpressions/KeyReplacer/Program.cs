using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace KeyReplacer
{
    class Program
    {
	static void Main()
	{
	    string input = Console.ReadLine();
	    Match key = Regex.Match(input, @"^(.+)[|<\\].*[|<\\](.+)$");
	    string keyStart = key.Groups[1].Value;
	    string keyEnd = key.Groups[2].Value;
	    string pattern = $@"(?<={keyStart})(.*?)(?={keyEnd})";
	    input = Console.ReadLine();
	    MatchCollection text = Regex.Matches(input, pattern);
	    string message = String.Join(String.Empty, text
		.Cast<Match>().Select(match => match.Value));
	    if (message != String.Empty)
		Console.WriteLine(message);
	    else Console.WriteLine("Empty result");
	}
    }
}