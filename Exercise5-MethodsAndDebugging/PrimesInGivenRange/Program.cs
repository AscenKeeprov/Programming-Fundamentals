using System;
using System.Collections.Generic;

namespace PrimesInGivenRange
{
	class Program
	{
		static List<int> PrimesInRange(int rangeStart, int rangeEnd)
		{
			List<int> primeNumbers = new List<int>();
			for (int number = rangeStart; number <= rangeEnd; number++)
			{
				bool isPrime = true;
				if (number == 0 || number == 1) isPrime = false;
				for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
				{
					if (number % divisor == 0)
					{
						isPrime = false;
						break;
					}
				}
				if (isPrime) primeNumbers.Add(number);
			}
			return primeNumbers;
		}

		static void Main(string[] args)
		{
			int rangeStart = int.Parse(Console.ReadLine());
			int rangeEnd = int.Parse(Console.ReadLine());
			if (rangeStart < rangeEnd)
			{
				List<int> primesList = PrimesInRange(rangeStart, rangeEnd);
				Console.Write($"{primesList[0]}");
				for (int i = 1; i < primesList.Count; i++)
				{
					Console.Write($", {primesList[i]}");
				}
				Console.WriteLine();
			}
		}
	}
}