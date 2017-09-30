using System;
using System.Collections.Generic;

namespace VowelOrDigit
{
	class Program
	{
		static void Main(string[] args)
		{
			char symbol = char.Parse(Console.ReadLine());
			int charValue = Convert.ToInt32(Char.ToLower(symbol));
			if (charValue >= 48 && charValue <= 57) Console.WriteLine("digit");
			else if (charValue == 97 || charValue == 101 || charValue == 105 || charValue == 111 || charValue == 117) Console.WriteLine("vowel");
			else Console.WriteLine("other");
		}
	}
}