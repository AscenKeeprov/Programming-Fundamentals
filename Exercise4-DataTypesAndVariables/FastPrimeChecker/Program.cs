using System;

namespace FastPrimeChecker
{
	class Program
	{
		static void Main(string[] args)
		{
			int maxNumber = int.Parse(Console.ReadLine());
			for (int number = 2; number <= maxNumber; number++)
			{
				bool isPrime = true;
				for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
				{
					if (number % divisor == 0)
					{
						isPrime = false;
						break;
					}
				}
				Console.WriteLine($"{number} -> {isPrime}");
			}
		}
	}
}