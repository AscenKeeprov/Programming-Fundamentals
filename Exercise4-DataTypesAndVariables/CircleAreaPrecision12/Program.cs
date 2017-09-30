using System;

namespace CircleAreaPrecision12
{
	class Program
	{
		static void Main(string[] args)
		{
			double radius = double.Parse(Console.ReadLine());
			Console.WriteLine("{0:F12}", Math.PI * Math.Pow(radius, 2));
		}
	}
}