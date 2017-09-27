using System;

namespace MilesToKilometres
{
	class Program
	{
		static void Main(string[] args)
		{
			double mi = double.Parse(Console.ReadLine());
			double km = mi * 1.60934;
			Console.WriteLine($"{km:F2}");
		}
	}
}