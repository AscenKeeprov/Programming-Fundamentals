using System;
using System.IO;
using System.Linq;

namespace MaxSequenceOfEquals
{
    class Program
    {
	static void Main()
	{
	    string[] input = File.ReadAllLines("inputMSoEE.txt");
	    if (File.Exists("outputMSoEE.txt")) File.Delete("outputMSoEE.txt");
	    foreach (string line in input)
	    {
		int[] numbers = line.Split().Select(int.Parse).ToArray();
		int[] sequence = new int[numbers.Length];
		int maxSequence = 1;
		int currentSequence = 1;
		for (int n = 1; n < numbers.Length; n++)
		{
		    if (numbers[n] == numbers[n - 1])
		    {
			currentSequence++;
			if (currentSequence > maxSequence)
			{
			    Array.Clear(sequence, 0, sequence.Length);
			    for (int s = 0; s < currentSequence; s++) sequence[s] = numbers[n];
			    maxSequence = currentSequence;
			}
		    }
		    else currentSequence = 1;
		}
		File.AppendAllText("outputMSoEE.txt", 
		    $"{String.Join(" ", sequence.Where(n => n != 0))}{Environment.NewLine}");
	    }
	}
    }
}