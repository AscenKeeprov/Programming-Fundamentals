using System;
using System.Linq;

namespace SubstringOccurrences
{
    class Program
    {
	static void Main()
	{
	    string input = Console.ReadLine();
	    char[] punctuation = input
		.Where(c => char.IsPunctuation(c) || c == ' ')
		.Except(new char[] { '\'', '-'})
		.ToArray();
	    string text = input.ToLower().Trim(punctuation);
	    string subText = Console.ReadLine().ToLower();
	    int occurrences = 0;
	    int checks = text.Length - subText.Length;
	    for (int i = 0; i <= checks; i++)
	    {
		if (text.Substring(i, subText.Length) == subText) occurrences++;
	    }
	    Console.WriteLine(occurrences);
	}
    }
}
