using System;

namespace UnicodeCharacters
{
    class Program
    {
	static void Main()
	{
	    string input = Console.ReadLine();
	    foreach (char c in input)
	    {
		Console.Write($@"\u{((uint)c).ToString("x4")}");
	    }
	}
    }
}