using System;

namespace TriangleOfNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			if (n >= 1 && n <= 20)
			{
				for (int r = 1; r <= n; r++)
				{
					for (int c = 1; c <= r; c++) Console.Write($"{r} ");
					Console.WriteLine();
				}
			}
		}
	}
}