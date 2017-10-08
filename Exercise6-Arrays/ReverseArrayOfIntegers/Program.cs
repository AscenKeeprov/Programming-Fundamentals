using System;

namespace ReverseArrayOfIntegers
{
    class Program
    {
	static void Main()
	{
	    int n = int.Parse(Console.ReadLine());
	    int[] integersArray = new int[n];
	    for (int i = 0; i < n; i++) integersArray[i] = int.Parse(Console.ReadLine());
	    Array.Reverse(integersArray);
	    for (int i = 0; i < n; i++) Console.Write($"{integersArray[i]} ");
	    Console.WriteLine();
	}
    }
}