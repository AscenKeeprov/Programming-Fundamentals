using System.IO;
using System.Linq;

namespace MostFrequentNumber
{
    class Program
    {
	static void Main()
	{
	    string[] input = File.ReadAllLines("inputMFN.txt");
	    string[] output = new string[input.Length];
	    for (uint line = 0; line < input.Length; line++)
	    {
		output[line] = input[line].Split()
		    .ToList().GroupBy(n => n)
		    .OrderByDescending(n => n.Count())
		    .Select(grp => grp.Key).First();
	    }
	    File.WriteAllLines("outputMFN.txt", output);
	}
    }
}