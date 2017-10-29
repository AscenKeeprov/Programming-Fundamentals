using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace QueryMess
{
    class Program
    {
	static void Main()
	{
	    Dictionary<string, List<string>> pairs = new Dictionary<string, List<string>>();
	    string input = Console.ReadLine();
	    while (input.ToUpper() != "END")
	    {
		string pattern = @"([^&?=]+)=([^&?=]*)";
		MatchCollection matches = Regex.Matches(input, pattern);
		string buffer = String.Empty;
		foreach (Match pair in matches)
		{
		    buffer = Regex.Replace(pair.Value, @"(?:%20|\+)+", " ");
		    string key = buffer.Split('=')[0].Trim();
		    string value = buffer.Split('=')[1].Trim();
		    if (!pairs.ContainsKey(key))
		    {
			pairs.Add(key, new List<string>());
			pairs[key].Add(value);
		    }
		    else pairs[key].Add(value);
		}
		foreach (var pair in pairs)
		    Console.Write($"{pair.Key}=[{String.Join(", ", pair.Value)}]");
		Console.WriteLine();
		pairs.Clear();
		input = Console.ReadLine();
	    }
	}
    }
}