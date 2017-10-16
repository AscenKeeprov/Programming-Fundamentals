using System;
using System.Collections.Generic;

namespace FixEmails
{
    class Program
    {
	static void Main()
	{
	    Dictionary<string, string> contacts = new Dictionary<string, string>();
	    string name = Console.ReadLine().Trim();
	    while (name != "stop")
	    {
		string email = Console.ReadLine().Trim();
		if (!contacts.ContainsValue(name)) contacts.Add(name, email);
		else contacts[name] = email;
		name = Console.ReadLine();
	    }
	    foreach (var entry in contacts)
		if (!entry.Value.EndsWith(".uk") && !entry.Value.EndsWith(".us"))
		    Console.WriteLine($"{entry.Key} -> {entry.Value}");
	}
    }
}