using System;
using System.IO;

namespace OddLines
{
    class Program
    {
	static void Main()
	{
	    string[] input = File.ReadAllLines("inputOL.txt");
	    if (File.Exists("outputOL.txt")) File.Delete("outputOL.txt");
	    for (uint line = 0; line < input.Length; line++)
		if(line % 2 != 0)
		    File.AppendAllText("outputOL.txt", $"" +
			$"{input[line]}{Environment.NewLine}");
	}
    }
}