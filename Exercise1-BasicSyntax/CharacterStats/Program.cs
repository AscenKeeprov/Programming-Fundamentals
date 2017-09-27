using System;

namespace CharacterStats
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			int curHealth = int.Parse(Console.ReadLine());
			int maxHealth = int.Parse(Console.ReadLine());
			int curNRG = int.Parse(Console.ReadLine());
			int maxNRG = int.Parse(Console.ReadLine());
			if (curHealth >= 0 && curHealth <= maxHealth && curNRG >= 0 && curNRG <= maxNRG)
			{
				Console.WriteLine($"Name: {name}");
				Console.WriteLine("Health: " + '|' + new string('|', curHealth) + new string('.', (maxHealth - curHealth)) + '|');
				Console.WriteLine("Energy: " + '|' + new string('|', curNRG) + new string('.', (maxNRG - curNRG)) + '|');
			}
		}
	}
}