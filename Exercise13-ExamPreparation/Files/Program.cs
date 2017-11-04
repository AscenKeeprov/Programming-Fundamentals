using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Files
{
    class Program
    {
	static void Main()
	{
	    int n = int.Parse(Console.ReadLine());
	    List<string> fileSystem = new List<string>();
	    for (int i = 1; i <= n; i++) fileSystem.Add(Console.ReadLine());
	    string searchCriteria = Console.ReadLine();
	    string fileType = searchCriteria.Split()[0];
	    string root = searchCriteria.Split()[2];
	    string pattern = $@"^({root}\\)(?:[^\\\/.:*?""<>|]+\\)*([^\\\/:*?""<>|]+\.{fileType});(\d+$)";
	    Dictionary<string, int> filesFound = new Dictionary<string, int>();
	    foreach (string fileInfo in fileSystem)
	    {
		Match match = Regex.Match(fileInfo, pattern);
		if (match.Success)
		{
		    string fileName = match.Groups[2].Value;
		    int fileSize = int.Parse(match.Groups[3].Value);
		    filesFound[fileName] = fileSize;
		}
	    }
	    if (filesFound.Count > 0)
		foreach (var file in filesFound
		    .OrderByDescending(f => f.Value).ThenBy(f => f.Key))
		    Console.WriteLine($"{file.Key} - {file.Value} KB");
	    else Console.WriteLine("No");
	}
    }
}