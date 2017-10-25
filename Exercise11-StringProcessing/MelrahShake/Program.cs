using System;

namespace MelrahShake
{
    class Program
    {
	static void Main()
	{
	    string input = Console.ReadLine();
	    string pattern = Console.ReadLine();
	    while (pattern.Length > 0)
	    {
		int firstMatch = input.IndexOf(pattern);
		int lastMatch = input.LastIndexOf(pattern);
		if (firstMatch >= 0 && lastMatch > firstMatch)
		{
		    input = input.Remove(lastMatch, pattern.Length);
		    input = input.Remove(firstMatch, pattern.Length);
		    pattern = pattern.Remove(pattern.Length / 2, 1);
		    Console.WriteLine("Shaked it.");
		}
		else break;
	    }
	    Console.WriteLine("No shake.");
	    Console.WriteLine(input);
	}
    }
}