using System;

namespace IndexOfLetters
{
    class Program
    {
	static void Main()
	{
	    char[] alphabet = new char[26];
	    for (int letter = 0; letter < alphabet.Length; letter++) alphabet[letter] = (char)(letter + 97);
	    string word = Console.ReadLine().Trim().ToLower();
	    foreach (char symbol in word)
	    {
		foreach (char letter in alphabet)
		{
		    if (symbol == letter) Console.WriteLine($"{symbol} -> {letter - 97}");
		}
	    }
	}
    }
}