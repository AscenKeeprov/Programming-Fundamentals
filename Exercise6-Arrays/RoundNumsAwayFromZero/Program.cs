using System;
using System.Linq;

namespace RoundNumsAwayFromZero
{
    class Program
    {
	static void Main()
	{
	    string[] input = Console.ReadLine().Trim().Split(' ');
	    double[] numArray = input.Select(double.Parse).ToArray();
	    foreach (double number in numArray)
	    {
		Console.WriteLine($"{number} => {Math.Round(number, 0, MidpointRounding.AwayFromZero)}");
	    }
	}
    }
}