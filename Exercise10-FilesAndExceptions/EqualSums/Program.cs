using System;
using System.IO;
using System.Linq;

namespace EqualSums
{
    class Program
    {
	static void Main()
	{
	    string[] input = File.ReadAllLines("inputES.txt");
	    if (File.Exists("outputES.txt")) File.Delete("outputES.txt");
	    foreach (string line in input)
	    {
		int[] numbers = line.Split().Select(int.Parse).ToArray();
		int sumLeft = 0;
		int sumRight = 0;
		bool hasEqualSum = false;
		for (int i = 0; i < numbers.Length; i++)
		{
		    sumLeft = numbers.Take(i).Sum();
		    sumRight = numbers.Skip(i + 1).Sum();
		    if (sumLeft == sumRight)
		    {
			hasEqualSum = true;
			File.AppendAllText("outputES.txt", $"{i}{Environment.NewLine}");
		    }
		}
		if (hasEqualSum == false)
		    File.AppendAllText("outputES.txt", $"no{Environment.NewLine}");
	    }
	}
    }
}