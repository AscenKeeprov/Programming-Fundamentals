using System;

namespace CalculateTriangleArea
{
	class Program
	{
		static double TriangleArea(double triangleBase, double triangleHeight)
		{
			return triangleBase * triangleHeight / 2;
		}

		static void Main(string[] args)
		{
			double triangleBase = double.Parse(Console.ReadLine());
			double triangleHeight = double.Parse(Console.ReadLine());
			Console.WriteLine(TriangleArea(triangleBase, triangleHeight));
		}
	}
}