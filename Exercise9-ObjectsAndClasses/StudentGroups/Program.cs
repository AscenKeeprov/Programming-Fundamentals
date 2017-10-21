using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace StudentGroups
{
    class Program
    {
	static void Main()
	{
	    Dictionary<Town, List<Student>> Registry = new Dictionary<Town, List<Student>>();
	    string input = Console.ReadLine();
	    while (input.Contains("=>") && input.ToUpper() != "END")
	    {
		string[] townInfo = input
		    .Split(new string[] { " => ", " seats", " seat" },
		    StringSplitOptions.RemoveEmptyEntries);
		Town town = new Town()
		{
		    Name = townInfo[0],
		    GroupLimit = int.Parse(townInfo[1]),
		};
		if (town.GroupLimit > 0)
		{
		    if (!Registry.Keys.Any(t => t.Name == town.Name)) Registry.Add(town, new List<Student>());
		    else
		    {
			Town existingTown = Registry.Keys.First(t => t.Name == town.Name);
			existingTown.GroupLimit += town.GroupLimit;
			town = existingTown;
		    }
		}
		input = Console.ReadLine();
		while (input.Contains("|"))
		{
		    string[] studentInfo = input
			.Split(new char[] { '|' },
			StringSplitOptions.RemoveEmptyEntries);
		    Student student = new Student()
		    {
			Name = studentInfo[0].Trim(),
			Email = studentInfo[1].Trim(),
			RegDate = DateTime.ParseExact(studentInfo[2].Trim(),
			"d-MMM-yyyy", CultureInfo.InvariantCulture)
		    };
		    Registry[town].Add(student);
		    town.Groups = (int)Math.Ceiling((double)Registry[town].Count() / town.GroupLimit);
		    input = Console.ReadLine();
		}
	    }
	    int totalGroups = 0;
	    int totalTowns = 0;
	    foreach (Town town in Registry.Keys.Where(t => t.Groups > 0))
	    {
		totalGroups += town.Groups;
		totalTowns++;
	    }
	    Console.WriteLine($"Created {totalGroups} groups in {totalTowns} towns:");
	    foreach (Town town in Registry.Keys.OrderBy(t => t.Name))
	    {
		List<Student> attendees = Registry[town]
		    .OrderBy(s => s.RegDate)
		    .ThenBy(s => s.Name)
		    .ThenBy(s => s.Email).ToList();
		for (int g = 1; g <= town.Groups; g++)
		{
		    Console.Write($"{town.Name} => ");
		    for (int i = (g - 1) * town.GroupLimit; i < g * Math.Min(town.GroupLimit, attendees.Count); i++)
		    {
			if (i == attendees.Count) break;
			Console.Write(attendees[i].Email);
			if ((i + 1.00) % Math.Min(town.GroupLimit, attendees.Count) != 0
			    && (i + 1.00) != attendees.Count) Console.Write(", ");
			else Console.WriteLine();
		    }
		}
	    }
	}
    }

    class Town
    {
	public string Name { get; set; }
	public int GroupLimit { get; set; }
	public int Groups { get; set; }
    }

    class Student
    {
	public string Name { get; set; }
	public string Email { get; set; }
	public DateTime RegDate { get; set; }
    }
}