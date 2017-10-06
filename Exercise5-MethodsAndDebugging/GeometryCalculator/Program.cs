using System;

namespace GeometryCalculator
{
	class Program
	{
		static double FigureArea(string figureType, double parameter1)
		{
			double area = 0.00;
			if (figureType == "circle") area = Math.PI * Math.Pow(parameter1, 2);
			else if (figureType == "square") area = Math.Pow(parameter1, 2);
			return area;
		}

		static double FigureArea(string figureType, double parameter1, double parameter2)
		{
			double area = 0.00;
			if (figureType == "triangle") area = parameter1 * parameter2 / 2.00;
			else if (figureType == "rectangle") area = parameter1 * parameter2;
			return area;
		}

		static void Main(string[] args)
		{
			string figureType = Console.ReadLine().ToLower();
			double parameter1 = double.Parse(Console.ReadLine());
			if (figureType == "triangle" || figureType == "rectangle")
			{
				double parameter2 = double.Parse(Console.ReadLine());
				Console.WriteLine($"{FigureArea(figureType, parameter1, parameter2):F2}");
			}
			else Console.WriteLine($"{FigureArea(figureType, parameter1):F2}");
		}
	}
}