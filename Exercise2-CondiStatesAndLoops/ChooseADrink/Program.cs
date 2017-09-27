using System;

namespace ChooseADrink
{
	class Program
	{
		static void Main(string[] args)
		{
			string profession = Console.ReadLine().ToLower();
			if (profession == "athlete") Console.WriteLine("Water");
			else if (profession == "businessman" || profession == "businesswoman") Console.WriteLine("Coffee");
			else if (profession == "softuni student") Console.WriteLine("Beer");
			else Console.WriteLine("Tea");
		}
	}
}