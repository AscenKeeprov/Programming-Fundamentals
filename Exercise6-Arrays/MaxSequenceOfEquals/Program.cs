using System;
using System.Linq;

namespace MaxSequenceOfEquals
{
    class Program
    {
	static void Main()
	{
	    string[] input = Console.ReadLine().Trim()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.ToArray();
	    int[] numsArray = input.Select(int.Parse).ToArray();
	    int[] sequence = new int[numsArray.Length];
	    int maxSequence = 1;
	    int currentSequence = 1;
	    for (int n = 1; n < numsArray.Length; n++)
	    {
		if (numsArray[n] == numsArray[n - 1])
		{
		    currentSequence++;
		    if (currentSequence > maxSequence)
		    {
			Array.Clear(sequence, 0, sequence.Length);
			for (int s = 0; s < currentSequence; s++) sequence[s] = numsArray[n];
			maxSequence = currentSequence;
		    }
		}
		else currentSequence = 1;
	    }
	    for (int s = 0; s < sequence.Length; s++)
	    {
		if (sequence[s] != 0) Console.Write($"{sequence[s]} ");
	    }
	    Console.WriteLine();
	}
    }
}