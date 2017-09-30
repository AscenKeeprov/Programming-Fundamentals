using System;

namespace RefactorSpecialNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int sumDigits = 0;
			for (int i = 1; i <= n; i++)
			{
				int number = i;
				while (number > 0)
				{
					sumDigits += number % 10;
					number /= 10;
				}
				bool specialNumber = sumDigits == 5 || sumDigits == 7 || sumDigits == 11;
				Console.WriteLine($"{i} -> {specialNumber}");
				sumDigits = 0;
			}
		}
	}
}