using System;

namespace SumOfOddNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int oddNum = 1;
			int oddSum = 0;
			for (int i = 1; i <= n; i++)
			{
				Console.WriteLine(oddNum);
				oddSum += oddNum;
				oddNum += 2;
			}
			Console.WriteLine($"Sum: {oddSum}");
		}
	}
}