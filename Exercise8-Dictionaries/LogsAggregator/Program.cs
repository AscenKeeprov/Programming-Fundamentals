using System;
using System.Collections.Generic;
using System.Linq;

namespace LogsAggregator
{
    class Program
    {
	static void Main()
	{
	    SortedDictionary<string/*user*/, SortedDictionary<string/*IP*/, int/*duration*/>> userLog = 
		new SortedDictionary<string, SortedDictionary<string, int>>();
	    ushort entryCount = ushort.Parse(Console.ReadLine());
	    for (ushort e = 1; e <= entryCount; e++)
	    {
		string[] input = Console.ReadLine()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.ToArray();
		string ip = input[0];
		string name = input[1];
		int duration = int.Parse(input[2]);
		if (!userLog.ContainsKey(name))
		{
		    userLog.Add(name, new SortedDictionary<string, int>());
		    userLog[name].Add(ip, duration);
		}
		else
		{
		    if (!userLog[name].ContainsKey(ip)) userLog[name].Add(ip, duration);
		    else userLog[name][ip] += duration;
		}
	    }
	    foreach (var user in userLog)
	    {
		Console.WriteLine($"{user.Key}: {user.Value.Values.Sum()} [{String.Join(", ", user.Value.Keys)}]");
	    }
	}
    }
}