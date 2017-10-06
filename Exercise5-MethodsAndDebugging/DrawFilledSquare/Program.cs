using System;

namespace DrawFilledSquare
{
	class Program
	{
		static void DrawSquareSide(int sideLength)
		{
			Console.WriteLine(new string('-', sideLength));
		}

		static void DrawSquareInside(int startInside, int endInside)
		{
			Console.Write("-");
			for (int i = startInside; i <= endInside; i++)
			{
				Console.Write(@"\/");
			}
			Console.WriteLine("-");
		}

		static void Main(string[] args)
		{
			int squareSize = int.Parse(Console.ReadLine());
			DrawSquareSide(2 * squareSize);
			for (int squareInside = 1; squareInside <= squareSize - 2; squareInside++) DrawSquareInside(1, squareSize - 1);
			DrawSquareSide(2 * squareSize);

		}
	}
}