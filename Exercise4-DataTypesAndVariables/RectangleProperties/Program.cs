using System;

namespace RectangleProperties
{
	class Program
	{
		static void Main(string[] args)
		{
			double rectangleWidth = double.Parse(Console.ReadLine());
			double rectangleHeight = double.Parse(Console.ReadLine());
			double rectanglePerimeter = 2 * rectangleWidth + 2 * rectangleHeight;
			double rectangleArea = rectangleWidth * rectangleHeight;
			double rectangleDiagonal = Math.Sqrt(Math.Pow(rectangleWidth,2) + Math.Pow(rectangleHeight, 2));
			Console.WriteLine($"{rectanglePerimeter:0.#}");
			Console.WriteLine($"{rectangleArea:0.##}");
			Console.WriteLine($"{rectangleDiagonal:0.#############}");
		}
	}
}