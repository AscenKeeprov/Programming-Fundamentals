using System;

namespace SignOfIntegerNumber
{
	class Program
	{
		static void PrintIntegerSign(int n)
		{
			if (n > 0) Console.WriteLine($"The number {n} is positive.");
			else if (n == 0) Console.WriteLine($"The number {n} is zero.");
			else if (n < 0) Console.WriteLine($"The number {n} is negative.");
		}

		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			PrintIntegerSign(number);
		}
	}
}