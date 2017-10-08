using System;

namespace LargestCommonEnd
{
    class Program
    {
	public static int CountEqualItems(string[] text1, string[] text2)
	{
	    int minLength = Math.Min(text1.Length, text2.Length);
	    int countEquals = 0;
	    for (int L = 0; L <= minLength - 1; L++)
	    {
		if (text1[L].Equals(text2[L])) countEquals++;
		else break;
	    }
	    return countEquals;
	}

	static void Main()
	{
	    string[] text1 = Console.ReadLine().Trim()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
	    string[] text2 = Console.ReadLine().Trim()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
	    int leftEquals = CountEqualItems(text1, text2);
	    Array.Reverse(text1);
	    Array.Reverse(text2);
	    int rightEquals = CountEqualItems(text1, text2);
	    Console.WriteLine(Math.Max(leftEquals, rightEquals));
	}
    }
}