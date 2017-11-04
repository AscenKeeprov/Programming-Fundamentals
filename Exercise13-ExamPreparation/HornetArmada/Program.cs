using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HornetArmada
{
    class Program
    {
	static void Main()
	{
	    Dictionary<Legion, List<Soldier>> armada = new Dictionary<Legion, List<Soldier>>();
	    int n = int.Parse(Console.ReadLine());
	    for (int i = 0; i < n; i++)
	    {
		string pattern = @"^(\d+)\s\=\s([^-=>: ]+)\s\-\>\s([^-=>: ]+)\:(\d+)$";
		Match armadaInfo = Regex.Match(Console.ReadLine(), pattern);
		if (armadaInfo.Success) PopulateArmada(armadaInfo, armada);
	    }
	    string[] printArgs = Console.ReadLine().Split('\\');
	    PrintLegions(printArgs, armada);
	}

	private static void PopulateArmada(Match armadaInfo, Dictionary<Legion, List<Soldier>> armada)
	{
	    Legion legion = new Legion()
	    {
		Name = armadaInfo.Groups[2].Value,
		Activity = int.Parse(armadaInfo.Groups[1].Value)
	    };
	    Soldier soldier = new Soldier()
	    {
		Type = armadaInfo.Groups[3].Value,
		Count = int.Parse(armadaInfo.Groups[4].Value)
	    };
	    if (!armada.Any(kvp => kvp.Key.Name == legion.Name))
	    {
		armada.Add(legion, new List<Soldier>());
		armada[legion].Add(soldier);
	    }
	    else
	    {
		Legion existingLegion = armada.Keys.First(l => l.Name == legion.Name);
		if (legion.Activity > existingLegion.Activity)
		    existingLegion.Activity = legion.Activity;
		if (!armada[existingLegion].Any(s => s.Type == soldier.Type))
		    armada[existingLegion].Add(soldier);
		else
		{
		    Soldier existingSoldier = armada[existingLegion].First(s => s.Type == soldier.Type);
		    int draft = armada[existingLegion].IndexOf(existingSoldier);
		    armada[existingLegion][draft].Count += soldier.Count;
		}
	    }
	}

	private static void PrintLegions(string[] printArgs, Dictionary<Legion, List<Soldier>> armada)
	{
	    if (printArgs.Length == 2)
	    {
		long maxActivity = long.Parse(printArgs[0]);
		string soldierType = printArgs[1];
		foreach (var legion in armada
		    .Where(l => l.Key.Activity < maxActivity && l.Value.Any(s => s.Type == soldierType))
		    .OrderByDescending(l => l.Value.First(s => s.Type == soldierType).Count))
		{
		    long soldierCount = legion.Value.First(s => s.Type == soldierType).Count;
		    Console.WriteLine($"{legion.Key.Name} -> {soldierCount}");
		}
	    }
	    if (printArgs.Length == 1)
	    {
		string soldierType = printArgs[0];
		foreach (var legion in armada.Where(l => l.Value.Any(s => s.Type == soldierType))
		    .OrderByDescending(l => l.Key.Activity))
		    Console.WriteLine($"{legion.Key.Activity} : {legion.Key.Name}");
	    }
	}
    }

    class Legion
    {
	public string Name { get; set; }
	public long Activity { get; set; }
    }

    class Soldier
    {
	public string Type { get; set; }
	public long Count { get; set; }
    }
}