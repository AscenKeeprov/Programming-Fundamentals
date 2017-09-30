using System;

namespace RefactorPyramidVolume
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Length: ");
			double pyramidLength = double.Parse(Console.ReadLine());
			Console.Write("Width: ");
			double pyramidWidth = double.Parse(Console.ReadLine());
			Console.Write("Height: ");
			double pyramidHeigth = double.Parse(Console.ReadLine());
			double pyramidVolume = pyramidLength * pyramidWidth * pyramidHeigth / 3;
			Console.WriteLine($"Pyramid Volume: {pyramidVolume:F2}");
		}
	}
}