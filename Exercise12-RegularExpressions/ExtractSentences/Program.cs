using System;
using System.Text.RegularExpressions;

namespace ExtractSentences
{
    class Program
    {
	static void Main()
	{
	    string word = Console.ReadLine();
	    string[] text = Console.ReadLine()
		.Split(new char[] { '.', '!', '?' }, 
		StringSplitOptions.RemoveEmptyEntries);
	    string pattern = "\\b" + word + "\\b";
	    foreach (string sentence in text)
	    {
		if(Regex.IsMatch(sentence, pattern))
		    Console.WriteLine(sentence.Trim());
	    }
	}
    }
}