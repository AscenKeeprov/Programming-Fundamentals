using System;
using System.Linq;

namespace RotateAndSum
{
    class Program
    {
	private static int[] RotateRight(int[] intArray)
	{
	    int arrayEnd = intArray[intArray.Length - 1];
	    for (int i = intArray.Length - 1; i >= 1; i--) intArray[i] = intArray[i - 1];
	    intArray[0] = arrayEnd;
	    return intArray;
	}

	static void Main()
	{
	    string[] input = Console.ReadLine().Trim()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
	    int k = int.Parse(Console.ReadLine());
	    int[] intArray = input.Select(int.Parse).ToArray();
	    int[] sumArray = new int[intArray.Length];
	    for (int rotation = 1; rotation <= k; rotation++)
	    {
		int[] rotArray = RotateRight(intArray);
		for (int i = 0; i < intArray.Length; i++) sumArray[i] += rotArray[i];
	    }
	    for (int i = 0; i < sumArray.Length; i++) Console.Write($"{sumArray[i]} ");
	    Console.WriteLine();
	}
    }
}