using System;

namespace LastKNumbersSums
{
    class Program
    {
	static void Main()
	{
	    int n = int.Parse(Console.ReadLine());
	    long[] intArray = new long[n];
	    intArray[0] = 1;
	    int k = int.Parse(Console.ReadLine());
	    Console.Write($"{intArray[0]} ");
	    for (int index = 1; index < n; index++)
	    {
		if (index < k)
		{
		    for (int trailLength = 0; trailLength <= index - 1; trailLength++)
		    {
			intArray[index] += intArray[trailLength];
		    }
		}
		else for (int trailLength = index - k; trailLength <= index - 1; trailLength++)
		    {
			intArray[index] += intArray[trailLength];
		    }
		Console.Write($"{intArray[index]} ");
	    }
	    Console.WriteLine();
	}
    }
}