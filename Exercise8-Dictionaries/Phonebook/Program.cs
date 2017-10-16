using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    class Program
    {
	static void Main()
	{
	    Dictionary<string, string> phonebook = new Dictionary<string, string>();
	    string[] input = Console.ReadLine()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.ToArray();
	    string command = input[0].ToLower();
	    while (command != "end")
	    {
		if (command == "a")
		{
		    string name = input[1];
		    string phoneNumber = input[2];
		    if (!phonebook.ContainsKey(name)) phonebook.Add(name, phoneNumber);
		    else phonebook[name] = phoneNumber;
		}
		else if (command == "s")
		{
		    string name = input[1];
		    if (phonebook.ContainsKey(name))
		    {
			string phoneNumber = phonebook[name];
			Console.WriteLine($"{name} -> {phoneNumber}");
		    }
		    else Console.WriteLine($"Contact {name} does not exist.");
		}
		input = Console.ReadLine()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.ToArray();
		command = input[0].ToLower();
	    }
	}
    }
}