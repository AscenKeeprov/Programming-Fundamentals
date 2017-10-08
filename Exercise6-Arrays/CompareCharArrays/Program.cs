using System;
using System.Linq;

namespace CompareCharArrays
{
    class Program
    {
	private static void Main()
	{
	    char[] chArray1 = Console.ReadLine().Trim()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.Select(char.Parse)
		.ToArray();
	    char[] chArray2 = Console.ReadLine().Trim()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.Select(char.Parse)
		.ToArray();
	    int minLength = Math.Min(chArray1.Length, chArray2.Length);
	    char[] firstArray = new char[minLength];
	    char[] secondArray = new char[minLength];
	    if (chArray1.Length < chArray2.Length)
	    {
		firstArray = chArray1;
		secondArray = chArray2;
	    }
	    else
	    {
		firstArray = chArray2;
		secondArray = chArray1;
	    }
	    for (int i = 0; i < minLength; i++)
	    {
		if (chArray1[i] < chArray2[i])
		{
		    firstArray = chArray1;
		    secondArray = chArray2;
		}
		else if (chArray2[i] < chArray1[i])
		{
		    firstArray = chArray2;
		    secondArray = chArray1;
		}
	    }
	    for (int l = 0; l < firstArray.Length; l++) Console.Write(firstArray[l]);
	    Console.WriteLine();
	    for (int l = 0; l < secondArray.Length; l++) Console.Write(secondArray[l]);
	    Console.WriteLine();
	}
    }
}