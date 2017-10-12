using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchForANumber
{
    class Program
    {
	static void Main()
	{
	    List<int> startIntegers = Console.ReadLine().Trim()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.Select(int.Parse).ToList();
	    int[] numbers = Console.ReadLine().Trim()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.Select(int.Parse).ToArray();
	    List<int> modifiedIntegers = startIntegers.Take(numbers[0]).ToList();
	    modifiedIntegers.RemoveRange(0, numbers[1]);
	    if (modifiedIntegers.Contains(numbers[2])) Console.WriteLine("YES!");
	    else Console.WriteLine("NO!");
	}
    }
}