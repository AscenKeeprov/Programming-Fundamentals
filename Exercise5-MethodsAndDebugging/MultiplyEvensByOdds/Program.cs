using System;

namespace MultiplyEvensByOdds
{
	class Program
	{
		static int GetEvenDigitsSum(int number)
		{
			int sumEvenDigits = 0;
			while (number > 0)
			{
				int digit = number % 10;
				if (digit % 2 == 0) sumEvenDigits += digit;
				number /= 10;
			}
			return sumEvenDigits;
		}

		static int GetOddDigitsSum(int number)
		{
			int sumOddDigits = 0;
			while (number > 0)
			{
				int digit = number % 10;
				if (digit % 2 != 0) sumOddDigits += digit;
				number /= 10;
			}
			return sumOddDigits;
		}

		static int MultiplyDigitSums(int number)
		{
			return GetEvenDigitsSum(number) * GetOddDigitsSum(number);
		}

		static void Main(string[] args)
		{
			int number = Math.Abs(int.Parse(Console.ReadLine()));
			Console.WriteLine(MultiplyDigitSums(number));
		}
	}
}