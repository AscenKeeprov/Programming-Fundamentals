using System;
using System.Data;
using System.Linq;

namespace CirclesIntersection
{
    class Program
    {
	static void Main()
	{
	    int[] input1 = Console.ReadLine()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.Select(int.Parse)
		.ToArray();
	    Point center1 = new Point() { X = input1[0], Y = input1[1] };
	    int radius1 = input1[2];
	    Circle circle1 = new Circle() { Center = Tuple.Create(center1.X, center1.Y), Radius = radius1 };
	    int[] input2 = Console.ReadLine()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.Select(int.Parse)
		.ToArray();
	    Point center2 = new Point() { X = input2[0], Y = input2[1] };
	    int radius2 = input2[2];
	    Circle circle2 = new Circle() { Center = Tuple.Create(center2.X, center2.Y), Radius = radius2 };
	    if (CirclesIntersect(circle1, circle2)) Console.WriteLine("Yes");
	    else Console.WriteLine("No");
	}

	private static bool CirclesIntersect(Circle circle1, Circle circle2)
	{
	    double distance = Math.Sqrt(Math.Pow(Math.Abs(circle1.Center.Item1 - circle2.Center.Item1), 2)
					+ Math.Pow(Math.Abs(circle1.Center.Item2 - circle2.Center.Item2), 2));
	    if (distance <= (circle1.Radius + circle2.Radius)) return true;
	    else return false;
	}
    }

    public class Circle
    {
	public Tuple<int, int> Center { get; set; }
	public int Radius { get; set; }
    }

    public class Point
    {
	public int X { get; set; }
	public int Y { get; set; }
    }
}