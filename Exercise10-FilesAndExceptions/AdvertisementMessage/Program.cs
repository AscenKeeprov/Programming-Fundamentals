using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdvertisementMessage
{
    class Program
    {
	static void Main()
	{
	    List<string> phrases = new List<string>
	    {
		"Excellent product.",
		"Such a great product.",
		"I always use that product.",
		"Best product of its category.",
		"Exceptional product.",
		"I can’t live without this product."
	    };
	    List<string> events = new List<string>
	    {
		"Now I feel good.",
		"I have succeeded with this product.",
		"Makes miracles. I am happy of the results!",
		"I cannot believe but now I feel awesome.",
		"Try it yourself, I am very satisfied.",
		"I feel great!"
	    };
	    List<string> authors = new List<string>
	    { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
	    List<string> cities = new List<string>
	    { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
	    int[] input = File.ReadAllLines("inputAM.txt").Select(int.Parse).ToArray();
	    if (File.Exists("outputAM.txt")) File.Delete("outputAM.txt");
	    Random rng = new Random();
	    for (int i = 0; i < input.Length; i++)
	    {
		int messageCount = input[i];
		for (int m = 1; m <= messageCount; m++)
		{
		    int phraseIndex = rng.Next(0, phrases.Count);
		    int eventIndex = rng.Next(0, events.Count);
		    int authorIndex = rng.Next(0, authors.Count);
		    int cityIndex = rng.Next(0, cities.Count);
		    string message = $"{phrases[phraseIndex]} {events[eventIndex]} " +
			$"{authors[authorIndex]} - {cities[cityIndex]}";
		    File.AppendAllText("outputAM.txt", message + Environment.NewLine);
		}
	    }
	}
    }
}