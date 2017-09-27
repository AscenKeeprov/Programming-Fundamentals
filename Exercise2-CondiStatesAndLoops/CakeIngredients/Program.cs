using System;

namespace CakeIngredients
{
	class Program
	{
		static void Main(string[] args)
		{
			string ingredient = "Thin Air";
			int ingreCount = 0;
			while (ingredient != "Bake!")
			{
				ingredient = Console.ReadLine();
				if (ingredient != "Bake!")
				{
					Console.WriteLine($"Adding ingredient {ingredient}.");
					ingreCount++;
				}
				else break;
			}
			Console.WriteLine($"Preparing cake with {ingreCount} ingredients.");
		}
	}
}