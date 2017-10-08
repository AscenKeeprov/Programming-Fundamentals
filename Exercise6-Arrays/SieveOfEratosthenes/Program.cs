using System;

namespace SieveOfEratosthenes
{
    class Program
    {
	private static void Main()
	{
	    int n = int.Parse(Console.ReadLine());
	    bool[] array = new bool[n + 1];
	    bool isPrime = true;
	    for (int num = 2; num <= n; num++) array[num] = isPrime;
	    for (int num = 2; num <= Math.Sqrt(n); num++)
	    {
		if (array[num] == isPrime)
		{
		    for (int position = num * num; position <= n; position += num)
		    {
			array[position] = !isPrime;
		    }
		}
	    }
	    for (int num = 2; num <= n; num++)
	    {
		if (array[num] == isPrime) Console.Write($"{num} ");
	    }
	    Console.WriteLine();
	}
    }
}