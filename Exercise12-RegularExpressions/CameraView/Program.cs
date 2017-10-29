using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CameraView
{
    class Program
    {
	static void Main()
	{
	    int[] framesToSort = Console.ReadLine().Split().Select(int.Parse).ToArray();
	    int m = framesToSort[0];
	    int n = framesToSort[1];
	    string pattern = $@"(?<=\|\<)(\w{{0,{m}}})(\w{{0,{n}}})[^|]*(\b|(?=\|\<))";
	    string input = Console.ReadLine();
	    MatchCollection cameras = Regex.Matches(input, pattern);
	    List<string> album = new List<string>();
	    foreach (Match footage in cameras)
	    {
		string view = footage.Value;
		int framesToSkip = Math.Min(m, view.Length);
		int framesToTake = Math.Min(n, view.Length - framesToSkip);
		string goodView = String.Join
		    (String.Empty, view.Skip(framesToSkip).Take(framesToTake));
		if (goodView != String.Empty) album.Add(goodView);
	    }
	    Console.WriteLine(String.Join(", ", album));
	}
    }
}