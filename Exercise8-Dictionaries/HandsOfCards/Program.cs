using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsOfCards
{
    class Program
    {
	static void PrintScores(Dictionary<string, List<string>> playerHands)
	{
	    foreach (var hand in playerHands)
	    {
		ushort handPower = 0;
		byte cardPower = 0;
		byte multiplier = 0;
		for (int card = 0; card < hand.Value.Count; card++)
		{
		    char cardID = hand.Value[card].First();
		    char cardSuit = hand.Value[card].Last();
		    if (hand.Value[card].Length > 2) cardPower = 10;
		    else if (cardID == 'J') cardPower = 11;
		    else if (cardID == 'Q') cardPower = 12;
		    else if (cardID == 'K') cardPower = 13;
		    else if (cardID == 'A') cardPower = 14;
		    else cardPower = (byte)(cardID - 48);
		    if (cardSuit == 'S') multiplier = 4;
		    else if (cardSuit == 'H') multiplier = 3;
		    else if (cardSuit == 'D') multiplier = 2;
		    else if (cardSuit == 'C') multiplier = 1;
		    handPower += (ushort)(cardPower * multiplier);
		}
		Console.WriteLine($"{hand.Key}: {handPower}");
	    }
	}

	static void Main()
	{
	    Dictionary<string/*играч*/, List<string>/*ръка*/> playerHands = new Dictionary<string, List<string>>();
	    string[] draw = Console.ReadLine()
		.Split(new string[] { ": "}, StringSplitOptions.RemoveEmptyEntries)
		.ToArray();
	    while (draw[0].ToUpper() != "JOKER")
	    {
		if (draw.Length > 1)
		{
		    string name = draw[0];
		    List<string> hand = draw[1].ToUpper()
			.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
			.Distinct()
			.ToList();
		    if (!playerHands.ContainsKey(name)) playerHands.Add(name, hand);
		    else playerHands[name].AddRange(hand.Except(playerHands[name]));
		}
		draw = Console.ReadLine()
		    .Split(new string[] { ": "}, StringSplitOptions.RemoveEmptyEntries)
		    .ToArray();
	    }
	    PrintScores(playerHands);
	}
    }
}