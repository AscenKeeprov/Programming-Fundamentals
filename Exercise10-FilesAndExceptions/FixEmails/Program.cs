using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FixEmails
{
    class Program
    {
	static void Main()
	{
	    Dictionary<string/*name*/, string/*email*/> contacts = new Dictionary<string, string>();
	    string[] input = File.ReadAllLines("inputFE.txt");
	    if (File.Exists("outputFE.txt")) File.Delete("outputFE.txt");
	    for (int i = 0; i < input.Length; i += 2)
	    {
		if (input[i].ToUpper() != "STOP")
		{
		    string name = input[i].Trim();
		    string email = input[i + 1].Trim();
		    if (!contacts.ContainsKey(name)) contacts.Add(name, email);
		    else contacts[name] = email;
		}
	    }
	    foreach (var entry in contacts
		.Where(e => !e.Value.EndsWith(".uk") && !e.Value.EndsWith(".us")))
	    File.AppendAllText("outputFE.txt", $"{entry.Key} -> {entry.Value}{Environment.NewLine}");
	}
    }
}