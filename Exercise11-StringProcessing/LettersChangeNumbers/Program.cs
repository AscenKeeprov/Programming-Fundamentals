using System;
using System.Linq;

namespace LettersChangeNumbers
{
    class Program
    {
	static void Main()
	{
	    string[] input = Console.ReadLine()
		.Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
	    double sumNumbers = 0;
	    foreach (string sequence in input)
	    {
		char firstChar = sequence.First();
		char lastChar = sequence.Last();
		double number = double.Parse(sequence.Substring(1, sequence.Length - 2));
		if (firstChar >= 65 && firstChar <= 90) number /= firstChar - 64;
		else if (firstChar >= 97 && firstChar <= 122) number *= firstChar - 96;
		if (lastChar >= 65 && lastChar <= 90) number -= lastChar - 64;
		else if (lastChar >= 97 && lastChar <= 122) number += lastChar - 96;
		sumNumbers += number;
	    }
	    Console.WriteLine($"{sumNumbers:F2}");
	}
    }
}