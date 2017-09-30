using System;

namespace TriplesOfLetters
{
	class Program
	{
		static void Main(string[] args)
		{
			byte numLetters = byte.Parse(Console.ReadLine());
			for (int firstLetter = 0; firstLetter < numLetters; firstLetter++)
			{
				for (int secondLetter = 0; secondLetter < numLetters; secondLetter++)
				{
					for (int thirdLetter = 0; thirdLetter < numLetters; thirdLetter++)
					{
						Console.WriteLine($"{(char)(firstLetter + 97)}{(char)(secondLetter + 97)}{(char)(thirdLetter + 97)}");
					}
				}
			}
		}
	}
}