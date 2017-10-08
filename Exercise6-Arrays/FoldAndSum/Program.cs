using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
	static void Main()
	{
	    int[] numArray = Console.ReadLine().Trim()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.Select(int.Parse).ToArray();
	    int k = numArray.Length / 4;
	    int[] topLeftRow = numArray.Take(k).ToArray();
	    int[] topRightRow = numArray.Skip(3 * k).Take(k).ToArray();
	    Array.Reverse(topLeftRow);
	    Array.Reverse(topRightRow);
	    int[] topRow = topLeftRow.Concat(topRightRow).ToArray();
	    int[] bottomRow = numArray.Skip(k).Take(2 * k).ToArray();
	    int[] result = new int[2 * k];
	    for (int i = 0; i < 2 * k; i++)
	    {
		result[i] = topRow[i] + bottomRow[i];
	    }
	    Console.WriteLine($"{string.Join(" ", result)}");
	}
    }
}