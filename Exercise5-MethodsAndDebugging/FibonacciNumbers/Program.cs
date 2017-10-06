using System;

namespace FibonacciNumbers
{
	class Program
	{
		static long FibonacciNumber(uint n)
		{
			long lastFibonacciNumber = 0;
			long nextFibonacciNumber = 1;
			for (int i = 0; i < n; i++)
			{
				long nFibonacciNumber = lastFibonacciNumber + nextFibonacciNumber;
				lastFibonacciNumber = nextFibonacciNumber;
				nextFibonacciNumber = nFibonacciNumber;
			}
			return nextFibonacciNumber;
		}

		static void Main(string[] args)
		{
			uint n = uint.Parse(Console.ReadLine());
			Console.WriteLine(FibonacciNumber(n));
		}
	}
}