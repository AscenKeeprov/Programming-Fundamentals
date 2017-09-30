using System;

namespace ExactSumOfRealNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			byte n = byte.Parse(Console.ReadLine());
			decimal sumNumbers = 0M;
			for (byte i = 1; i <= n; i++)
			{
				decimal number = decimal.Parse(Console.ReadLine());
				sumNumbers += number;
			}
			Console.WriteLine($"{sumNumbers:G29}");
		}
	}
}