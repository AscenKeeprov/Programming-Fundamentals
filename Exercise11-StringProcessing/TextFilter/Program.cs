using System;

namespace TextFilter
{
    class Program
    {
	static void Main()
	{
	    string[] filter = Console.ReadLine()
		.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
	    string text = Console.ReadLine();
	    for (int f = 0; f < filter.Length; f++)
	    {
		if (text.Contains(filter[f]))
		{
		    text = text.Replace(filter[f], new string('*', filter[f].Length));
		}
	    }
	    Console.WriteLine(text);
	}
    }
}