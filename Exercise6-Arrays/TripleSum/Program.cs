using System;
using System.Linq;

namespace TripleSum
{
    class Program
    {
	static void Main()
	{
	    string[] input = Console.ReadLine().Trim().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
	    int[] integerArray = input.Select(int.Parse).ToArray();
	    bool hasTripleSum = false;
	    for (int a = 0; a < integerArray.Length; a++)
	    {
		for (int b = 0; b < integerArray.Length; b++)
		{
		    for (int c = 0; c < integerArray.Length; c++)
		    {
			if (integerArray[a] + integerArray[b] == integerArray[c] && a < b)
			{
			    Console.WriteLine($"{integerArray[a]} + {integerArray[b]} == {integerArray[c]}");
			    hasTripleSum = true;
			    break;
			}
		    }
		}
	    }
	    if (hasTripleSum == false) Console.WriteLine("No");
	}
    }
}