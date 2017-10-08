using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
	static void Main()
	{
	    string[] input = Console.ReadLine().Trim()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.ToArray();
	    int[] numsArray = input.Select(int.Parse).ToArray();
	    int sumLeft= 0;
	    int sumRight = 0;
	    bool hasEqualSum = false;
	    if (numsArray.Length > 1)
	    {
		for (int i = 0; i < numsArray.Length; i++)
		{
		    sumLeft = numsArray.Take(i).Sum();
		    sumRight = numsArray.Skip(i + 1).Sum();
		    if (sumLeft == sumRight)
		    {
			hasEqualSum = true;
			Console.WriteLine(i);
		    }
		}
		if (hasEqualSum == false) Console.WriteLine("no");
	    }
	    else Console.WriteLine(0);
	}
    }
}