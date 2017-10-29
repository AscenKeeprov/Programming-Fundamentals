using System;
using System.Text.RegularExpressions;

namespace ValidUsernames
{
    class Program
    {
	static void Main()
	{
	    string pattern = @"(?<=\b|\s|\\|\/|\)|\()[a-zA-Z]\w{2,24}(?=\b|\s|\\|\/|\)|\()";
	    MatchCollection userDB = Regex.Matches(Console.ReadLine(), pattern);
	    string[] maxUsers = new string[2];
	    int maxSum = 0;
	    for (int i = 0; i < userDB.Count - 1; i++)
	    {
		int currentSum = userDB[i].Length + userDB[i + 1].Length;
		if (currentSum > maxSum)
		{
		    maxUsers[0] = userDB[i].Value;
		    maxUsers[1] = userDB[i + 1].Value;
		    maxSum = currentSum;
		}
	    }
	    foreach (string username in maxUsers)
		Console.WriteLine(username);
	}
    }
}