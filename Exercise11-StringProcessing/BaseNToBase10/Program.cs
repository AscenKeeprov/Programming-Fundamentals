using System;
using System.Linq;
using System.Numerics;

namespace BaseNToBase10
{
    class Program
    {
	static void Main()
	{
	    string[] input = Console.ReadLine().Trim().Split();
	    byte baseN = byte.Parse(input[0]);
	    string numberN = new string(input[1].Reverse().ToArray());
	    BigInteger number10 = 0;
	    if (baseN >= 2 && baseN <= 10)
	    {
		for (byte d = 0; d < numberN.Length; d++)
		{
		    number10 += BigInteger.Parse(numberN[d].ToString()) * BigInteger.Pow(baseN, d);
		}
		Console.WriteLine(number10);
	    }
	}
    }
}