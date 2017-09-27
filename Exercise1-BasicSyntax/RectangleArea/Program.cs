using System;

namespace RectangleArea
{
	class Program
	{
		static void Main(string[] args)
		{
			double w = double.Parse(Console.ReadLine());
			double h = double.Parse(Console.ReadLine());
			var area = w * h;
			Console.WriteLine($"{area:F2}");
		}
	}
}