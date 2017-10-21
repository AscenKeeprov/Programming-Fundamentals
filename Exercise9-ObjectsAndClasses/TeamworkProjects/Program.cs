using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Program
    {
	static void Main()
	{
	    List<Team> teams = new List<Team>();
	    int n = int.Parse(Console.ReadLine());
	    for (int c = 1; c <= n; c++)
	    {
		string teamCreate = Console.ReadLine();
		Team team = new Team()
		{
		    Name = teamCreate.Split('-')[1],
		    Leader = teamCreate.Split('-')[0],
		    Members = new List<string>()
		};
		if (teams.Any(t => t.Name == team.Name))
		    Console.WriteLine($"Team {team.Name} was already created!");
		else if (teams.Any(t => t.Leader == team.Leader))
		    Console.WriteLine($"{team.Leader} cannot create another team!");
		else
		{
		    teams.Add(team);
		    Console.WriteLine($"Team {team.Name} has been created by {team.Leader}!");
		}
	    }
	    string teamJoin = Console.ReadLine();
	    while (teamJoin.ToUpper() != "END OF ASSIGNMENT")
	    {
		Team team = new Team()
		{
		    Name = teamJoin.Split(new string[] { "->" }, StringSplitOptions.None)[1],
		    Members = new List<string>
		    { teamJoin.Split(new string[] { "->" }, StringSplitOptions.None)[0] }
		};
		if (!teams.Any(t => t.Name == team.Name))
		    Console.WriteLine($"Team {team.Name} does not exist!");
		else if (teams.Any(t => t.Members.Contains(team.Members[0]) || t.Leader == team.Members[0]))
		    Console.WriteLine($"Member {team.Members[0]} cannot join team {team.Name}!");
		else
		{
		    Team existingTeam = teams.First(t => t.Name == team.Name);
		    existingTeam.Members.Add(team.Members[0]);
		}
		teamJoin = Console.ReadLine();
	    }
	    foreach (Team team in teams
		.Where(t => t.Members.Count > 0)
		.OrderByDescending(t => t.Members.Count)
		.ThenBy(t => t.Name))
	    {
		Console.WriteLine(team.Name);
		Console.WriteLine($"- {team.Leader}");
		foreach (string member in team.Members.OrderBy(m => m))
		    Console.WriteLine($"-- {member}");
	    }
	    Console.WriteLine("Teams to disband:");
	    foreach (Team team in teams.Where(t => t.Members.Count == 0)
		.OrderBy(t => t.Name))
		Console.WriteLine(team.Name);
	}
    }

    public class Team
    {
	public string Name { get; set; }
	public string Leader { get; set; }
	public List<string> Members { get; set; }
    }
}