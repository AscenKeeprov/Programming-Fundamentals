using System;
using System.Linq;
using System.Text;

namespace SumBigNumbers
{
    class Program
    {
	static void Main()
	{
	    string num1 = Console.ReadLine();
	    string num2 = Console.ReadLine();
	    if (num1.Length > num2.Length)
		num2 = num2.PadLeft(num1.Length, '0');
	    else if (num2.Length > num1.Length)
		num1 = num1.PadLeft(num2.Length, '0');
	    StringBuilder sum = new StringBuilder();
	    int remainder = 0;
	    for (int i = num1.Length - 1; i >= 0; i--)
	    {
		int digit = num1[i] - 48 + num2[i] - 48 + remainder;
		if (digit > 9)
		{
		    remainder = digit / 10;
		    digit %= 10;
		}
		else remainder = 0;
		sum.Append(digit);
	    }
	    sum.Append(remainder);
	    string result = String.Join("", sum.ToString()
		.Reverse().ToArray()).TrimStart('0');
	    Console.WriteLine(result);
	}
    }
}