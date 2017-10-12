using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
	static void Main()
	{
	    List<int> numbers = Console.ReadLine().Trim()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.Select(int.Parse).ToList();
	    string[] input = Console.ReadLine().Trim().ToLower()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
	    string command = input[0];
	    while (command != "print")
	    {
		if (command == "add")
		    numbers.Insert(int.Parse(input[1]), int.Parse(input[2]));
		else if (command == "addmany")
		    numbers.InsertRange(int.Parse(input[1]), input.Skip(2).Select(int.Parse).ToList());
		else if (command == "contains")
		    Console.WriteLine(numbers.IndexOf(int.Parse(input[1])));
		else if (command == "remove")
		    numbers.RemoveAt(int.Parse(input[1]));
		else if (command == "shift")
		{
		    int positions = int.Parse(input[1]);
		    if (positions > numbers.Count) positions = positions % numbers.Count;
		    List<int> movedElements = numbers.Take(positions).ToList();
		    numbers.RemoveRange(0, positions);
		    numbers.AddRange(movedElements);
		}
		else if (command == "sumpairs")
		{
		    if (numbers.Count % 2 == 0)
		    {
			for (int i = 0; i < numbers.Count - 1; i++)
			{
			    numbers[i] = numbers[i] + numbers[i + 1];
			    numbers.RemoveAt(i + 1);
			}
		    }
		    else
		    {
			for (int i = 0; i < numbers.Count - 2; i++)
			{
			    numbers[i] = numbers[i] + numbers[i + 1];
			    numbers.RemoveAt(i + 1);
			}
		    }
		}
		input = Console.ReadLine().Trim().ToLower()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
		command = input[0];
	    }
	    Console.WriteLine($"[{string.Join(", ", numbers)}]");
	}
    }
}