using System;

namespace NumberChecker
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine().Trim();
			double result = 0;
			if (double.TryParse(input, out result)) Console.WriteLine("It is a number.");
			else Console.WriteLine("Invalid input!");
		}
	}
}