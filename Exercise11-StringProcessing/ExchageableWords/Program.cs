using System;
using System.Linq;

namespace ExchageableWords
{
    class Program
    {
	static void Main()
	{
	    string[] input = Console.ReadLine().Split().ToArray();
	    string word1 = input[0];
	    string word2 = input[1];
	    Console.WriteLine(ExchangeWords(word1, word2));
	}

	static string ExchangeWords(string word1, string word2)
	{
	    char[] letters1 = word1.Distinct().ToArray();
	    char[] letters2 = word2.Distinct().ToArray();
	    if (letters1.Length == letters2.Length) return "true";
	    else return "false";
	}
    }
}