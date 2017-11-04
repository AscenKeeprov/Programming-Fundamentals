using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PokemonEvolution
{
    class Program
    {
	static void Main()
	{
	    Dictionary<string, List<Evolution>> pokemons = new Dictionary<string, List<Evolution>>();
	    string input = Console.ReadLine();
	    while (input != "wubbalubbadubdub")
	    {
		Match pokemonInfo = Regex.Match(input, @"^([^->]+)\s\-\>\s([^->]+)\s\-\>\s(\d+)$");
		if (pokemonInfo.Success)
		{
		    string pokemonName = pokemonInfo.Groups[1].Value;
		    Evolution evolution = new Evolution()
		    {
			Type = pokemonInfo.Groups[2].Value,
			Index = int.Parse(pokemonInfo.Groups[3].Value)
		    };
		    if (!pokemons.ContainsKey(pokemonName))
		    {
			pokemons.Add(pokemonName, new List<Evolution>());
			pokemons[pokemonName].Add(evolution);
		    }
		    else pokemons[pokemonName].Add(evolution);
		}
		else
		{
		    string pokemonName = input;
		    if (pokemons.ContainsKey(pokemonName))
		    {
			List<Evolution> evolutions = pokemons[pokemonName];
			Console.WriteLine($"# {pokemonName}");
			foreach (var evolution in evolutions)
			    Console.WriteLine($"{evolution.Type} <-> {evolution.Index}");
		    }
		}
		input = Console.ReadLine();
	    }
	    foreach (var pokemon in pokemons)
	    {
		Console.WriteLine($"# {pokemon.Key}");
		foreach (Evolution evolution in pokemon.Value.OrderByDescending(e => e.Index))
		    Console.WriteLine($"{evolution.Type} <-> {evolution.Index}");
	    }
	}
    }

    class Evolution
    {
	public string Type { get; set; }
	public int Index { get; set; }
    }
}