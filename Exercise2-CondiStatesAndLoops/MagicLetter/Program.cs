using System;

namespace MagicLetter
{
	class Program
	{
		static void Main(string[] args)
		{
			char letter1 = char.Parse(Console.ReadLine());
			char letter2 = char.Parse(Console.ReadLine());
			string letter3 = Console.ReadLine();
			for (char first = letter1; first <= letter2; first++)
			{
				for (char second = letter1; second <= letter2; second++)
				{
					for (char third = letter1; third <= letter2; third++)
					{
						string combination = $"{first}{second}{third} ";
						if (!combination.Contains(letter3))
						{
							Console.Write(combination);
						}
					}
				}
			}
			Console.WriteLine();
		}
	}
}