using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
	static void Main()
	{
	    List<int> numbers = Console.ReadLine()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.Select(int.Parse).ToList();
	    int[] input = Console.ReadLine()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.Select(int.Parse).ToArray();
	    int bomb = input[0];
	    int yield = input[1];
	    int field = numbers.Count;
	    for (int i = 0; i < field; i++)
	    {
		if (numbers[i] == bomb)
		{
		    int groundZero = numbers.IndexOf(numbers[i]);
		    if (groundZero - yield < 0)
		    {
			numbers.RemoveRange(0, groundZero);
			field -= groundZero;
			groundZero = 0;
			if (numbers.Count - 1 - yield < 0)
			{
			    numbers.RemoveRange(groundZero, numbers.Count);
			    field = 0;
			}
			else
			{
			    numbers.RemoveRange(groundZero, yield + 1);
			    field -= yield + 1;
			}
		    }
		    else
		    {
			numbers.RemoveRange(groundZero - yield, yield);
			field -= yield;
			groundZero = groundZero - yield;
			if (numbers.Count - 1 - groundZero - yield < 0)
			{
			    numbers.RemoveRange(groundZero, numbers.Count - groundZero);
			    field = 0;
			}
			else
			{
			    numbers.RemoveRange(groundZero, yield + 1);
			    field -= yield + 1;
			}
		    }
		    i = -1;
		}
	    }
	    Console.WriteLine(numbers.Sum());
	}
    }
}