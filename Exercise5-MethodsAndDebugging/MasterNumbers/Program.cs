using System;

namespace MasterNumbers
{
	class Program
	{
		static bool SumDigitsDivisibleBy7(uint number)
		{
			uint sumDigits = 0;
			while (number > 0)
			{
				uint digit = number % 10;
				sumDigits += digit;
				number /= 10;
			}
			if (sumDigits % 7 == 0) return true;
			else return false;
		}

		static bool HasEvenDigit(uint number)
		{
			bool hasEvenDigit = false;
			while (number > 0)
			{
				uint digit = number % 10;
				if (digit % 2 == 0)
				{
					hasEvenDigit = true;
					break;
				}
				number /= 10;
			}			
			return hasEvenDigit;
		}

		static bool IsSymmetric(uint number)
		{
			uint originalNum = number;
			uint reverseNum = 0;
			while (number > 0)
			{
				uint digit = number % 10;
				reverseNum = reverseNum * 10 + digit;
				number /= 10;
			}
			if (reverseNum == originalNum) return true;
			else return false;
		}

		static bool IsMaster (uint number)
		{
			if (IsSymmetric(number) && HasEvenDigit(number) && SumDigitsDivisibleBy7(number)) return true;
			else return false;
		}

		static void Main(string[] args)
		{
			uint n = uint.Parse(Console.ReadLine());
			for (uint number = 1; number <= n; number++)
			{
				if (IsMaster(number)) Console.WriteLine(number);
			}
		}
	}
}