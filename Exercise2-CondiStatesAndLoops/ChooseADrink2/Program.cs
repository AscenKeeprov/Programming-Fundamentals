using System;

namespace ChooseADrink2
{
	class Program
	{
		static void Main(string[] args)
		{
			string profession = Console.ReadLine();
			int quantity = int.Parse(Console.ReadLine());
			double price = 0.00;
			if (profession == "Athlete") price = 0.7 * quantity;
			else if (profession == "Businessman" || profession == "Businesswoman") price = 1 * quantity;
			else if (profession == "SoftUni Student") price = 1.7 * quantity;
			else price = 1.2 * quantity;
			Console.WriteLine($"The {profession} has to pay {price:F2}.");
		}
	}
}