using System;
using System.Numerics;
using System.Text;

namespace Base10ToBaseN
{
    class Program
    {
	static void Main()
	{
	    string[] input = Console.ReadLine().Trim().Split();
	    byte baseN = byte.Parse(input[0]);
	    BigInteger number10 = BigInteger.Parse(input[1]);
	    StringBuilder numberN = new StringBuilder();
	    if (baseN >= 2 && baseN <= 10)
	    {
		while (number10 > 0)
		{
		    BigInteger remainder = number10 % baseN;
		    numberN.Insert(0, remainder);
		    number10 = (number10 - remainder) / baseN;
		}
	    }
	    string result = String.Join(String.Empty, numberN);
	    Console.WriteLine(result);
	}
    }
}