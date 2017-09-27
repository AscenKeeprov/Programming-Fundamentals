using System;

namespace TestNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int N = int.Parse(Console.ReadLine());
			int M = int.Parse(Console.ReadLine());
			int comboCount = 0;
			int sum = 0;
			int maxSum = int.Parse(Console.ReadLine());
			for (int leftNum = N; leftNum >= 1; leftNum--)
			{
				for (int rightNum = 1; rightNum <= M; rightNum++)
				{
					comboCount++;
					sum += leftNum * rightNum * 3;
					if (sum >= maxSum)
					{
						Console.WriteLine($"{comboCount} combinations");
						Console.WriteLine($"Sum: {sum} >= {maxSum}");
						return;
					}
				}
			}
			Console.WriteLine($"{comboCount} combinations");
			Console.WriteLine($"Sum: {sum}");
		}
	}
}