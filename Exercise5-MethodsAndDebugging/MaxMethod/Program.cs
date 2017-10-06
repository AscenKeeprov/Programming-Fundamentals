using System;

namespace MaxMethod
{
	class Program
	{
		static int GetMax(int a, int b)
		{
			int biggerNum = Math.Max(a, b);
			return biggerNum;
		}

		static void Main(string[] args)
		{
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			int num3 = int.Parse(Console.ReadLine());
			int biggestNum = GetMax(GetMax(num1, num2),GetMax(num2, num3));
			Console.WriteLine(biggestNum);
		}
	}
}