using System;

namespace PrintTriangle
{
	class Program
	{
		static void PrintTriangleTop(int topStart, int topEnd)
		{
			for (int t = topStart; t <= topEnd; t++) Console.Write($"{t} ");
			Console.WriteLine();
		}

		static void PrintTriangleMiddle(int middleStart, int middleEnd)
		{
			for (int m = middleStart; m <= middleEnd; m++) Console.Write($"{m} ");
			Console.WriteLine();
		}

		static void PrintTriangleBottom(int bottomStart, int bottomEnd)
		{
			for (int t = bottomStart; t <= bottomEnd; t++) Console.Write($"{t} ");
			Console.WriteLine();
		}

		static void Main(string[] args)
		{
			int triangleSize = int.Parse(Console.ReadLine());
			for (int triangleTop = 1; triangleTop < triangleSize; triangleTop++) PrintTriangleTop(1, triangleTop);
			PrintTriangleMiddle(1, triangleSize);
			for (int triangleBottom = triangleSize - 1; triangleBottom >= 1; triangleBottom--) PrintTriangleBottom(1, triangleBottom);
		}
	}
}