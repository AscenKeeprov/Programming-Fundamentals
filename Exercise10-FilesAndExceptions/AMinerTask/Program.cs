using System;
using System.Collections.Generic;
using System.IO;

namespace AMinerTask
{
    class Program
    {
	static void Main()
	{
	    Dictionary<string/*resource*/, ulong/*quantity*/> wagon = new Dictionary<string, ulong>();
	    string[] input = File.ReadAllLines("inputAMT.txt");
	    if (File.Exists("outputAMT.txt")) File.Delete("outputAMT.txt");
	    for (int r = 0; r < input.Length; r += 2)
	    {
		if (input[r].ToUpper() != "STOP")
		{
		    string resource = input[r];
		    ulong quantity = ulong.Parse(input[r + 1]);
		    if (!wagon.ContainsKey(resource)) wagon.Add(resource, quantity);
		    else wagon[resource] += quantity;
		}
	    }
	    foreach (var ore in wagon)
		File.AppendAllText("outputAMT.txt", $"{ore.Key} -> {ore.Value}{Environment.NewLine}");
	}
    }
}