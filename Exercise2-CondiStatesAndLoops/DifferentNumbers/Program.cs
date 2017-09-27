using System;

namespace FiveDifferentNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int minNum = Math.Min(a, b);
			int maxNum = Math.Max(a, b);
			int numDiff = Math.Abs(maxNum - minNum);
			if (numDiff > 3)
			{
				for (int num1 = minNum; num1 <= maxNum; num1++)
				{
					for (int num2 = minNum; num2 <= maxNum; num2++)
					{
						for (int num3 = minNum; num3 <= maxNum; num3++)
						{
							for (int num4 = minNum; num4 <= maxNum; num4++)
							{
								for (int num5 = minNum; num5 <= maxNum; num5++)
								{
									if (minNum <= num1 && num1 < num2 && num2 < num3 && num3 < num4 && num4 < num5 && num5 <= maxNum)
										Console.WriteLine($"{num1} {num2} {num3} {num4} {num5}");
								}
							}
						}
					}
				}
			}
			else Console.WriteLine("No");
		}
	}
}