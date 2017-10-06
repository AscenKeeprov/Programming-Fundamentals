using System;
using System.Numerics;

namespace Factorial
{
	class Program
	{
		static BigInteger Factorial(uint number)
		{
			BigInteger factorial = 1;
			for (uint i = 1; i <= number; i++) factorial *= i;
			return factorial;
		}

		static void Main(string[] args)
		{
			uint n = uint.Parse(Console.ReadLine());
			Console.WriteLine(Factorial(n));
		}
	}
}