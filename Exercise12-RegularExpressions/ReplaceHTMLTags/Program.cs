using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ReplaceHTMLTags
{
    class Program
    {
	static void Main()
	{
	    string patternFrom = @"<a\s+href\s*=(\s*.*\s*)>(.*?)<\/a>";
	    string patternTo = @"[URL href=$1]$2[/URL]";
	    List<string> HTML = new List<string>();
	    string input = Console.ReadLine();
	    while (input.ToUpper() != "END")
	    {
		string line = Regex.Replace(input, patternFrom, patternTo);
		HTML.Add(line);
		input = Console.ReadLine();
	    }
	    foreach (string line in HTML) Console.WriteLine(line);
	}
    }
}