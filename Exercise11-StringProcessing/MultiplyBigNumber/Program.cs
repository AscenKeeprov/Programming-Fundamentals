using System;
using System.Linq;
using System.Text;

namespace MultiplyBigNumbers
{
    class Program
    {
	static void Main()
	{
	    string num1 = Console.ReadLine().Trim();
	    if (num1.Any(c => c != '0')) num1 = num1.TrimStart('0');
	    string num2 = Console.ReadLine().Trim();
	    if (num2.Any(c => c != '0')) num2 = num2.TrimStart('0');
	    StringBuilder product = new StringBuilder();
	    int remainder = 0;
	    for (int i = num1.Length - 1; i >=0 ; i--)
	    {
		int digit = (num1[i] - 48) * (char.Parse(num2) - 48) + remainder;
		if (digit > 9)
		{
		    remainder = digit / 10;
		    digit %= 10;
		}
		else remainder = 0;
		product.Insert(0, digit);
	    }
	    product.Insert(0, remainder);
	    string result = product.ToString();
	    if (result.Any(c => c != '0')) result = result.TrimStart('0');
	    else result = "0";
	    Console.WriteLine(result);
	}
    }
}