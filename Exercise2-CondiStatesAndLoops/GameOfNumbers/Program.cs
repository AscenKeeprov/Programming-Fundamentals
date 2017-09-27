using System;

namespace GameOfNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int N = int.Parse(Console.ReadLine());
			int M = int.Parse(Console.ReadLine());
			int minNum = Math.Min(M, N);
			int maxNum = Math.Max(M, N);
			int leftNum = -1;
			int rightNum = -1;
			int magicNum = int.Parse(Console.ReadLine());
			bool magic = false;
			int comboCount = 0;
			for (int L = minNum; L <= maxNum; L++)
			{
				for (int R = minNum; R <= maxNum; R++)
				{
					comboCount++;
					if (L + R == magicNum)
					{
						leftNum = L;
						rightNum = R;
						magic = true;
					}
				}
			}
			if (magic) Console.WriteLine($"Number found! {leftNum} + {rightNum} = {magicNum}");
			else Console.WriteLine($"{comboCount} combinations - neither equals {magicNum}");
		}
	}
}