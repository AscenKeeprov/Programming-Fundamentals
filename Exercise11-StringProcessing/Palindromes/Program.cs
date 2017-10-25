using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindromes
{
    class Program
    {
	static void Main()
	{
	    string input = Console.ReadLine();
	    char[] punctuation = input
		.Where(c => char.IsPunctuation(c) || c == ' ')
		.Except(new char[] { '\'', '-' })
		.ToArray();
	    string[] text = input
		.Split(punctuation, StringSplitOptions.RemoveEmptyEntries)
		.ToArray();
	    List<string> palindromes = new List<string>();
	    foreach (string word in text)
	    {
		string reverseWord = new string (word.Reverse().ToArray());
		if (word == reverseWord && !palindromes.Contains(word))
		    palindromes.Add(word);
	    }
	    Console.WriteLine(String.Join(", ", palindromes.OrderBy(w => w)));
	}
    }
}