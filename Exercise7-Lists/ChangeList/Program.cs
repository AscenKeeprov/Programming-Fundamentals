using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
	public static void Main()
	{
	    List<int> numbers = Console.ReadLine().Trim()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.Select(int.Parse).ToList();
	    string[] input = Console.ReadLine().Trim().ToLower()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
	    string command = input[0];
	    while (command != "odd" && command != "even")
	    {
		if (command == "insert")
		{
		    int number = int.Parse(input[1]);
		    int position = int.Parse(input[2]);
		    if (position < 0) numbers.Insert(0, number);
		    else if (position >= numbers.Count) numbers.Add(number);
		    else numbers.Insert(position, number);
		}
		else if (command == "delete")
		{
		    int number = int.Parse(input[1]);
		    numbers.RemoveAll(item => item == number);
		}
		input = Console.ReadLine().Trim().ToLower()
		    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
		command = input[0];
	    }
	    for (int i = 0; i < numbers.Count; i++)
	    {
		if (command == "odd" && numbers[i] % 2 != 0) Console.Write($"{numbers[i]} ");
		else if (command == "even" && numbers[i] % 2 == 0) Console.Write($"{numbers[i]} ");
	    }
	    Console.WriteLine();
	}
    }
}