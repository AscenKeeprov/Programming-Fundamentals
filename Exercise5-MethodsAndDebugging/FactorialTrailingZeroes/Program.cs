using System;
using System.Numerics;

namespace FactorialTrailingZeroes
{
	class Program
	{
		static uint FactorialTrailingZeroes(uint number)
		{
			BigInteger factorial = 1;
			for (uint i = 1; i <= number; i++) factorial *= i;
			uint trailingZeroes = 0;
			while (factorial % 10 == 0)
			{
				trailingZeroes++;
				factorial /= 10;
			}
			return trailingZeroes;
		}

		static void Main(string[] args)
		{
			uint n = uint.Parse(Console.ReadLine());
			Console.WriteLine(FactorialTrailingZeroes(n));
		}
	}
}