using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace WinningTicket
{
    class Program
    {
	static void Main()
	{
	    string pattern = @"((?:(\#){6,}|(\$){6,}|(\@){6,}|(\^){6,})).*?((?:(\2){6,}|(\3){6,}|(\4){6,}|(\5){6,}))";
	    List<string> tickets = Regex.Matches(Console.ReadLine(), @"[^\s,]+")
		.Cast<Match>().Select(match => match.Value).ToList();
	    foreach (string ticket in tickets)
	    {
		if (ticket.Length != 20) Console.WriteLine("invalid ticket");
		else
		{
		    Match winningTicket = Regex.Match(ticket, pattern);
		    if (winningTicket.Success)
		    {
			string leftHalf = ticket.Substring(0, 10);
			leftHalf = Regex.Match(leftHalf, @"(\#{6,}|\${6,}|\@{6,}|\^{6,})").ToString();
			string rightHalf = ticket.Substring(10, 10);
			rightHalf = Regex.Match(rightHalf, @"(\#{6,}|\${6,}|\@{6,}|\^{6,})").ToString();
			if ((leftHalf.Length + rightHalf.Length) == 20)
			    Console.WriteLine($"ticket \"{ticket}\" - 10{leftHalf.First()} Jackpot!");
			else
			{
			    int prize = Math.Min(leftHalf.Length, rightHalf.Length);
			    Console.WriteLine($"ticket \"{ticket}\" - {prize}{leftHalf.First()}");
			}
		    }
		    else Console.WriteLine($"ticket \"{ticket}\" - no match");
		}
	    }
	}
    }
}