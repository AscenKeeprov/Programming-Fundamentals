using System;
using System.Linq;

namespace MaxSequenceOfGreaters
{
    class Program
    {
	static void Main()
	{
	    string[] numsArray = Console.ReadLine().Trim()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.ToArray();
	    string[] sequence = new string[numsArray.Length];
	    int maxSequence = 1;
	    int currentSequence = 1;
	    int sequenceStart;
	    for (int n = 1; n < numsArray.Length; n++)
	    {
		if (int.Parse(numsArray[n]) > int.Parse(numsArray[n - 1]))
		{
		    currentSequence++;
		    if (currentSequence > maxSequence)
		    {
			Array.Clear(sequence, 0, sequence.Length);
			sequenceStart = n + 1 - currentSequence;
			Array.ConstrainedCopy(numsArray, sequenceStart, sequence, 0, currentSequence);
			maxSequence = currentSequence;
		    }
		}
		else currentSequence = 1;
	    }
	    for (int s = 0; s < sequence.Length; s++)
	    {
		if (sequence[s] != null) Console.Write($"{sequence[s]} ");
	    }
	    Console.WriteLine();
	}
    }
}