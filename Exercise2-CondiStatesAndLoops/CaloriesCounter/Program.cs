using System;

namespace CaloriesCounter
{
	class Program
	{
		static void Main(string[] args)
		{
			int ingreCount = int.Parse(Console.ReadLine());
			if (ingreCount > 0 && ingreCount <= 20)
			{
				int calories = 0;
				for (int i = 1; i <= ingreCount; i++)
				{
					string ingredient = Console.ReadLine().Trim().ToLower();
					if (ingredient.Length >= 1 && ingredient.Length <= 50)
					{
						switch (ingredient)
						{
							case "cheese":
								calories += 500;
								break;
							case "pepper":
								calories += 50;
								break;
							case "salami":
								calories += 600;
								break;
							case "tomato sauce":
								calories += 150;
								break;
						}
					}
				}
				Console.WriteLine($"Total calories: {calories}");
			}
		}
	}
}