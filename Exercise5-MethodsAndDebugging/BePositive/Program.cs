using System;
using System.Collections.Generic;

namespace BePositive
{
	class Program
	{
		static void Main(string[] args)
		{
			int sequencesCount = int.Parse(Console.ReadLine());
			for (int s = 0; s < sequencesCount; s++)
			{
				string[] input = Console.ReadLine().Trim().Split(' ');
				var numbersList = new List<int>();
				for (int i = 0; i < input.Length; i++)
				{
					if (!input[i].Equals(string.Empty))
					{
						int number = int.Parse(input[i]);
						numbersList.Add(number);
					}
				}
				bool foundPositive = false;
				bool addedNegative = false;
				int lastNum = 0;
				for (int l = 0; l < numbersList.Count; l++)
				{
					int currentNum = numbersList[l];
					if (lastNum < 0 && addedNegative == false)
					{
						currentNum += lastNum;
						lastNum = 0;
						addedNegative = true;
					}
					if (currentNum >= 0)
					{
						Console.Write($"{currentNum} ");
						foundPositive = true;
						addedNegative = false;
					}
					else
					{
						if (addedNegative == false) lastNum = currentNum;
						else
						{
							lastNum = 0;
							addedNegative = false;
						}
					}
				}
				if (!foundPositive) Console.WriteLine("(empty)");
				else Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
}