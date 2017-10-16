using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
	static void Main()
	{
	    Dictionary<string, int> minersLog = new Dictionary<string, int>();
	    string resource = Console.ReadLine().Trim();
	    while (resource != "stop")
	    {
		int quantity = int.Parse(Console.ReadLine().Trim());
		if (!minersLog.ContainsKey(resource)) minersLog.Add(resource, quantity);
		else minersLog[resource] += quantity;
		resource = Console.ReadLine();
	    }
	    foreach (var entry in minersLog) Console.WriteLine($"{entry.Key} -> {entry.Value}");
	}
    }
}