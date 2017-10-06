using System;

namespace CenterPoint
{
	class Program
	{
		static string CloserToCenter(double X1, double Y1, double X2, double Y2)
		{
			double distance1 = Math.Sqrt(Math.Pow(X1, 2) + Math.Pow(Y1, 2));
			double distance2 = Math.Sqrt(Math.Pow(X2, 2) + Math.Pow(Y2, 2));
			if (distance1 <= distance2) return $"({X1}, {Y1})";	
			else return $"({X2}, {Y2})"; ;
		}

		static void Main(string[] args)
		{
			double X1 = double.Parse(Console.ReadLine());
			double Y1 = double.Parse(Console.ReadLine());
			double X2 = double.Parse(Console.ReadLine());
			double Y2 = double.Parse(Console.ReadLine());
			Console.WriteLine(CloserToCenter(X1, Y1, X2, Y2));
		}
	}
}