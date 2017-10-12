using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceOfEquals
{
    class Program
    {
	public static void Main()
	{
	    List<int> numbers = Console.ReadLine().Trim()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.Select(int.Parse).ToList();
	    int equalNumber = numbers[0];
	    uint currentSequence = 1;
	    uint maxSequence = 1;
	    for (int i = 0; i < numbers.Count - 1; i++)
	    {
		if (numbers[i] == numbers[i + 1])
		{
		    currentSequence++;
		    if (currentSequence > maxSequence)
		    {
			equalNumber = numbers[i];
			maxSequence = currentSequence;
		    }
		}
		else currentSequence = 1;
	    }
	    for (int i = 0; i < maxSequence; i++) Console.Write($"{equalNumber} ");
	    Console.WriteLine();
	}
    }
}