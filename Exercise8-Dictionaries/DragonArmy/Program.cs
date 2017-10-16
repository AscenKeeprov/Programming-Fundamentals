using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonArmy
{
    class Program
    {
	static void Main()
	{
	    List<Dragon> dragonFlight = new List<Dragon>();
	    byte flightSize = byte.Parse(Console.ReadLine());
	    for (byte i = 1; i <= flightSize; i++)
	    {
		string[] egg = Console.ReadLine()
		    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
		    .ToArray();
		Dragon whelp = Hatch(egg);
		if (!dragonFlight.Any(d => d.Name == whelp.Name && d.Type == whelp.Type))
		    dragonFlight.Add(whelp);
		else
		{
		    Dragon oldster = dragonFlight.First(d => d.Name == whelp.Name && d.Type == whelp.Type);
		    dragonFlight.Insert(dragonFlight.IndexOf(oldster), whelp);
		    dragonFlight.Remove(oldster);
		}
	    }
	    foreach (string dragonType in dragonFlight.Select(d => d.Type).Distinct())
	    {
		double averageDamage = dragonFlight.Where(d => d.Type == dragonType).Average(d => d.Damage);
		double averageHealth = dragonFlight.Where(d => d.Type == dragonType).Average(d => d.Health);
		double averageArmor = dragonFlight.Where(d => d.Type == dragonType).Average(d => d.Armor);
		Console.WriteLine($"{dragonType}::({averageDamage:F2}/{averageHealth:F2}/{averageArmor:F2})");
		foreach (Dragon dragon in dragonFlight.Where(d => d.Type == dragonType).OrderBy(d => d.Name))
		    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
	    }
	}

	public static Dragon Hatch(string[] egg)
	{
	    Dragon whelp = new Dragon();
	    whelp.Type = egg[0];
	    whelp.Name = egg[1];
	    if (egg[2] != "null") whelp.Damage = uint.Parse(egg[2]);
	    else whelp.Damage = 45;
	    if (egg[3] != "null") whelp.Health = uint.Parse(egg[3]);
	    else whelp.Health = 250;
	    if (egg[4] != "null") whelp.Armor = uint.Parse(egg[4]);
	    else whelp.Armor = 10;
	    return whelp;
	}
    }

    public class Dragon
    {
	public string Type { get; set; }
	public string Name { get; set; }
	public uint Damage { get; set; }
	public uint Health { get; set; }
	public uint Armor { get; set; }
    }
}