using System;
using System.IO;

namespace IndexOfLetters
{
    class Program
    {
	static void Main()
	{
	    char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
	    string[] input = File.ReadAllLines("inputIOL.txt");
	    if (File.Exists("outputIOL.txt")) File.Delete("outputIOL.txt");
	    foreach (string word in input)
		foreach (char letter in word.ToLower())
		    File.AppendAllText("outputIOL.txt", $"{letter} -> " +
			$"{Array.IndexOf(alphabet, letter)}{Environment.NewLine}");
	}
    }
}