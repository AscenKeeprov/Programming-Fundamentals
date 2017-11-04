using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CommandInterpreter
{
    class Program
    {
	static void Main()
	{
	    List<string> input = Regex.Matches(Console.ReadLine(), @"[^\s]+")
		.Cast<Match>().Select(match => match.Value).ToList();
	    List<string> output = input.ToList();
	    string[] command = Console.ReadLine().ToUpper().Split();
	    string action = command[0];
	    while (action != "END")
	    {
		switch (command.Length)
		{
		    case 5:
			try
			{
			    int startIndex = int.Parse(command[2]);
			    int count = int.Parse(command[4]);
			    if (commandIsValid(input, startIndex, count))
			    {
				if (action == "REVERSE" || action == "SORT")
				    output = Reorder(output, action, startIndex, count);
				else goto default;
			    }
			    else goto default;
			}
			catch
			{
			    goto default;
			}
			break;
		    case 3:
			try
			{
			    int count = int.Parse(command[1]);
			    if (count >= 0)
			    {
				if (String.Join("", action.Take(4)) == "ROLL")
				    output = Roll(output, action, count);
				else goto default;
			    }
			    else goto default;
			}
			catch
			{
			    goto default;
			}
			break;
		    default:
			Console.WriteLine("Invalid input parameters.");
			break;
		}
		command = Console.ReadLine().ToUpper().Split();
		action = command[0];
	    }
	    Console.WriteLine($"[{String.Join(", ", output)}]");
	}

	private static bool commandIsValid(List<string> output, int startIndex, int count)
	{
	    if (startIndex >= 0 && startIndex < output.Count()
		&& count >= 0 && count <= output.Count() - startIndex) return true;
	    else return false;
	}

	private static List<string> Reorder(List<string> output, string action, int startIndex, int count)
	{
	    List<string> segment = output.Skip(startIndex).Take(count).ToList();
	    output.RemoveRange(startIndex, count);
	    if (action == "REVERSE") segment.Reverse();
	    else if (action == "SORT") segment.Sort();
	    output.InsertRange(startIndex, segment);
	    return output;
	}

	private static List<string> Roll(List<string> output, string action, int count)
	{
	    count %= output.Count;
	    string direction = String.Join("", action.Skip(4));
	    if (direction == "LEFT")
	    {
		for (int rolls = 0; rolls < count; rolls++)
		{
		    string seriesStart = output.First();
		    for (int i = 0; i < output.Count - 1; i++) output[i] = output[i + 1];
		    output[output.Count - 1] = seriesStart;
		}
	    }
	    else if (direction == "RIGHT")
	    {
		for (int rolls = 0; rolls < count; rolls++)
		{
		    string seriesEnd = output.Last();
		    for (int i = output.Count - 1; i > 0; i--) output[i] = output[i - 1];
		    output[0] = seriesEnd;
		}
	    }
	    return output;
	}
    }
}