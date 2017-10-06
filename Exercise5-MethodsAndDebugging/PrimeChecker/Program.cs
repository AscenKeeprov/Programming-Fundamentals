using System;

namespace PrimeChecker
{
	class Program
	{
		static bool IsPrime(long n)
		{
			bool isPrime = true;
			if (n == 0 || n == 1) isPrime = false;
			for (int divisor = 2; divisor <= Math.Sqrt(n); divisor++)
			{
				if (n % divisor == 0)
				{
					isPrime = false;
					break;
				}
			}
			return isPrime;
		}

		static void Main(string[] args)
		{
			long n = long.Parse(Console.ReadLine());
			Console.WriteLine(IsPrime(n));
		}
	}
}