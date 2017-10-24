using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
	static void Main()
	{
	    Dictionary<string, int> wordsFound = new Dictionary<string, int>();
	    string input = File.ReadAllText("text.txt");
	    char[] punctuation = input
		.Where(c => char.IsPunctuation(c) || c == ' ')
		.Except("'").Distinct().ToArray();
	    string[] text = input.ToLower()
		.Split(punctuation, StringSplitOptions.RemoveEmptyEntries);
	    string[] words = File.ReadAllText("words.txt").Split().ToArray();
	    if (File.Exists("outputLN.txt")) File.Delete("outputLN.txt");
	    for (uint word = 0; word < text.Length; word++)
	    {
		if (words.Contains(text[word]))
		{
		    if (!wordsFound.ContainsKey(text[word]))
			wordsFound.Add(text[word], 1);
		    else wordsFound[text[word]]++;
		}
	    }
	    foreach (var word in wordsFound.OrderByDescending(count => count.Value))
		File.AppendAllText("outputLN.txt", $"{word.Key} - {word.Value}{Environment.NewLine}");
	}
    }
}