using System;

namespace CubeProperties
{
	class Program
	{
		static double CalculateCube(double cubeSide, string calcParameter)
		{
			double result = 0.00;
			if (calcParameter == "face") result = Math.Sqrt(2 * Math.Pow(cubeSide, 2));
			else if (calcParameter == "space") result = Math.Sqrt(3 * Math.Pow(cubeSide, 2));
			else if (calcParameter == "volume") result = Math.Pow(cubeSide, 3);
			else if (calcParameter == "area") result = 6 * Math.Pow(cubeSide, 2);
			return result;
		}

		static void Main(string[] args)
		{
			double cubeSide = double.Parse(Console.ReadLine());
			string calcParameter = Console.ReadLine();
			Console.WriteLine($"{CalculateCube(cubeSide, calcParameter):F2}");
		}
	}
}