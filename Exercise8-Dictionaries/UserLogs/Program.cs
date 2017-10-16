using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    class Program
    {
	static void Main()
	{
	    SortedDictionary<string/*user*/, Dictionary<string/*IP*/, int/*logons*/>> userLog = 
		new SortedDictionary<string, Dictionary<string, int>>();
	    string[] input = Console.ReadLine()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.ToArray();
	    while (input[0].ToUpper() != "END")
	    {
		string ip = input[0].Split('=')[1];
		string name = input[2].Split('=')[1];
		if (!userLog.ContainsKey(name)) userLog[name] = new Dictionary<string, int>();
		if (!userLog[name].ContainsKey(ip)) userLog[name][ip] = 1;
		else userLog[name][ip]++;
		input = Console.ReadLine()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.ToArray();
	    }
	    foreach (var user in userLog)
	    {
		Console.WriteLine($"{user.Key}: ");
		Console.Write(String.Join(", ", user.Value.Select(ip => $"{ip.Key} => {ip.Value}")));
		Console.WriteLine(".");
	    }
	}
    }
}