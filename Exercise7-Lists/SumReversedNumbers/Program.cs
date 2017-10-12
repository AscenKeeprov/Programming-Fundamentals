using System;
using System.Collections.Generic;
using System.Linq;

namespace SumReversedNumbers
{
    class Program
    {
	static void Main()
	{
	    List<int> numbers = Console.ReadLine().Trim()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.Select(int.Parse).ToList();
	    int reverseNumSum = 0;
	    for (int i = 0; i < numbers.Count; i++)
	    {
		string reverseNum = "";
		char[] numDigits = Math.Abs(numbers[i]).ToString().Reverse().ToArray();
		for (int d = 0; d < numDigits.Length; d++) reverseNum += numDigits[d];
		if (numbers[i] < 0) reverseNumSum += int.Parse(reverseNum) * -1;
		else reverseNumSum += int.Parse(reverseNum);
	    }
	    Console.WriteLine(reverseNumSum);
	}
    }
}