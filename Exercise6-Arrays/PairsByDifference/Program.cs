using System;
using System.Linq;

namespace PairsByDifference
{
    class Program
    {
	static void Main()
	{
	    string[] input = Console.ReadLine().Trim()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.ToArray();
	    double difference = double.Parse(Console.ReadLine());
	    double[] numsArray = input.Select(double.Parse).ToArray();
	    ushort diffPairs = 0;
	    for (ushort i = 0; i < numsArray.Length - 1; i++)
	    {
		for (ushort j = 1; j < numsArray.Length; j++)
		{
		    if (Math.Abs(numsArray[i] - numsArray[j]) == difference && i < j) diffPairs++;
		}
	    }
	    Console.WriteLine(diffPairs);
	}
    }
}