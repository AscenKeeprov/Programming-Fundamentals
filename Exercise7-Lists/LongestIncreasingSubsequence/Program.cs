using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSubsequence
{
    class Program
    {
	static void Main()
	{
	    List<int> numbers = Console.ReadLine()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.Select(int.Parse).ToList();
	    int[] currSeqLength = new int[numbers.Count];
	    int[] prevSeqPosition = new int[numbers.Count];
	    int maxSeqLength = 0;
	    int prevSeqIndex = -1;
	    for (int i = 0; i < numbers.Count; i++)
	    {
		currSeqLength[i] = 1;
		prevSeqPosition[i] = -1;
		for (int j = 0; j < i; j++)
		{
		    if (numbers[j] < numbers[i] && currSeqLength[j] >= currSeqLength[i])
		    {
			currSeqLength[i] = currSeqLength[j] + 1;
			prevSeqPosition[i] = j;
		    }
		}
		if (currSeqLength[i] > maxSeqLength)
		{
		    maxSeqLength = currSeqLength[i];
		    prevSeqIndex = i;
		}
	    }
	    List<int> maxSequence = new List<int>();
	    for (int i = 0; i < maxSeqLength; i++)
	    {
		maxSequence.Add(numbers[prevSeqIndex]);
		prevSeqIndex = prevSeqPosition[prevSeqIndex];
	    }
	    maxSequence.Reverse();
	    Console.WriteLine(string.Join(" ", maxSequence));
	}
    }
}