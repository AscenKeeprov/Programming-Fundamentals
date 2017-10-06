using System;

namespace LongerLine
{
	class Program
	{
		static string LongerLine(double X1, double Y1, double X2, double Y2, double X3, double Y3, double X4, double Y4)
		{
			double line1Length = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
			double line2Length = Math.Sqrt(Math.Pow(X3 - X4, 2) + Math.Pow(Y3 - Y4, 2));
			if (line1Length >= line2Length)
			{
				double point1DistanceToCenter = Math.Sqrt(Math.Pow(X1, 2) + Math.Pow(Y1, 2));
				double point2DistanceToCenter = Math.Sqrt(Math.Pow(X2, 2) + Math.Pow(Y2, 2));
				if (point1DistanceToCenter <= point2DistanceToCenter) return $"({X1}, {Y1})({X2}, {Y2})";
				else return $"({X2}, {Y2})({X1}, {Y1})";
			}
			else
			{
				double point3DistanceToCenter = Math.Sqrt(Math.Pow(X3, 2) + Math.Pow(Y3, 2));
				double point4DistanceToCenter = Math.Sqrt(Math.Pow(X4, 2) + Math.Pow(Y4, 2));
				if (point3DistanceToCenter <= point4DistanceToCenter) return $"({X3}, {Y3})({X4}, {Y4})";
				else return $"({X4}, {Y4})({X3}, {Y3})";
			}
		}

		static void Main(string[] args)
		{
			double X1 = double.Parse(Console.ReadLine());
			double Y1 = double.Parse(Console.ReadLine());
			double X2 = double.Parse(Console.ReadLine());
			double Y2 = double.Parse(Console.ReadLine());
			double X3 = double.Parse(Console.ReadLine());
			double Y3 = double.Parse(Console.ReadLine());
			double X4 = double.Parse(Console.ReadLine());
			double Y4 = double.Parse(Console.ReadLine());
			Console.WriteLine(LongerLine(X1, Y1, X2, Y2, X3, Y3, X4, Y4));
		}
	}
}