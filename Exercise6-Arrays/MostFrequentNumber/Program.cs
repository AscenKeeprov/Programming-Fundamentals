using System;
using System.Linq;

namespace MostFrequentNumber
{
    class Program
    {
	static void Main()
	{
	    string[] input = Console.ReadLine().Trim()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.ToArray();
	    ushort[] numsArray = input.Select(ushort.Parse).ToArray();
	    ushort[] copyArray = input.Select(ushort.Parse).ToArray();
	    int oldMax = 0;
	    int newMax = 0;
	    ushort topNum = 0;
	    for (int i = 0; i < numsArray.Length; i++)
	    {
		for (int j = 0; j < copyArray.Length; j++)
		{
		    if (copyArray[j] == numsArray[i])
		    {
			newMax++;
			if (newMax > oldMax)
			{
			    topNum = numsArray[i];
			    oldMax = newMax;
			}
		    }
		}
		newMax = 0;
	    }
	    Console.WriteLine(topNum);
	}
    }
}