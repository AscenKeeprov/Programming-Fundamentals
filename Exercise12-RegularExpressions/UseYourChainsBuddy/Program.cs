using System;
using System.Text;
using System.Text.RegularExpressions;

namespace UseYourChainsBuddy
{
    class Program
    {
	static void Main()
	{
	    string HTML = Console.ReadLine();
	    MatchCollection paragraphs = Regex.Matches(HTML, @"(?<=<p>)(.*?)(?=<\/p>)");
	    StringBuilder cipher = new StringBuilder();
	    string buffer = String.Empty;
	    foreach (Match p in paragraphs)
	    {
		buffer = Regex.Replace(p.Value, @"[^a-z0-9]+", " ");
		cipher.Append(buffer);
	    }
	    for (int c = 0; c < cipher.Length; c++)
	    {
		if (cipher[c] >= 97 && cipher[c] <= 109) cipher[c] = (char)(cipher[c] + 13);
		else if (cipher[c] >= 110 && cipher[c] <= 122) cipher[c] = (char)(cipher[c] - 13);
	    }
	    string text = cipher.ToString();
	    Console.WriteLine(text);
	}
    }
}