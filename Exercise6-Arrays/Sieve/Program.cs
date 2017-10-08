using System;

namespace Sieve
{
    class Program
    {
	static void Main(string[] args)
	{
	    int n = int.Parse(Console.ReadLine());
	    bool[] array = new bool[n + 1];
	    for (int i = 2; i < n; i++) array[i] = true;
	    for (int i = 0; i < n; i++)
	    {
		if (array[i] == true)
		{
		    for (int a = 2; (a * i) <= n; a++) array[a * i] = false;
		}
	    }
	    for (int j = 2; j < n; j++)
	    {
		if (array[j] == true) Console.Write(j + " ");
	    }
	    Console.WriteLine();
	}
    }
}