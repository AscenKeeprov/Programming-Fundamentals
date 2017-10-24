using System;
using System.IO;

namespace LineNumbers
{
    class Program
    {
	static void Main()
	{
	    string[] input = File.ReadAllLines("inputLN.txt");
	    if (File.Exists("outputLN.txt")) File.Delete("outputLN.txt");
	    for (uint line = 0; line < input.Length; line++)
		File.AppendAllText("outputLN.txt", $"" +
		    $"{line + 1}. {input[line]}{Environment.NewLine}");
	}
    }
}