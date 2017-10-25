using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {
	static void Main()
	{
	    string input = Console.ReadLine();
	    string output = String.Join(String.Empty, input.Reverse().ToArray());
	    Console.WriteLine(output);
	}
    }
}