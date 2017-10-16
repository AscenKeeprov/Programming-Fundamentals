using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
	static void Main()
	{
	    SortedDictionary<string/*item*/, int/*quantity*/> inventory =
		new SortedDictionary<string, int> { ["fragments"] = 0, ["motes"] = 0, ["shards"] = 0 };
	    bool legendary = false;
	    while (legendary == false)
	    {
		string[] loot = Console.ReadLine()
		.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		.ToArray();
		for (byte i = 0; i < loot.Length; i += 2)
		{
		    int quantity = int.Parse(loot[i]);
		    string item = loot[i + 1].ToLower();
		    if (!inventory.ContainsKey(item)) inventory.Add(item, quantity);
		    else inventory[item] += quantity;
		    if (inventory["fragments"] >= 250 || inventory["motes"] >= 250 || inventory["shards"] >= 250)
		    {
			if (item == "fragments") Console.WriteLine("Valanyr obtained!");
			else if (item == "motes") Console.WriteLine("Dragonwrath obtained!");
			else if (item == "shards") Console.WriteLine("Shadowmourne obtained!");
			inventory[item] -= 250;
			legendary = true;
			break;
		    }
		}
	    }
	    foreach (var valuable in inventory.OrderByDescending(item => item.Value))
	    {
		if (valuable.Key == "fragments" || valuable.Key == "motes" || valuable.Key == "shards")
		    Console.WriteLine($"{valuable.Key}: {valuable.Value}");
	    }
	    foreach (var junk in inventory)
	    {
		if (junk.Key != "fragments" && junk.Key != "motes" && junk.Key != "shards")
		    Console.WriteLine($"{junk.Key}: {junk.Value}");
	    }
	}
    }
}