using System;

namespace Hotel
{
	class Program
	{
		static void Main(string[] args)
		{
			string month = Console.ReadLine().ToLower();
			int nights = int.Parse(Console.ReadLine());
			double stPrice = 0.00;
			double doPrice = 0.00;
			double suPrice = 0.00;
			if (month == "may")
			{
				if (nights > 0 && nights <= 7)
				{
					stPrice = 50 * nights;
					doPrice = 65 * nights;
					suPrice = 75 * nights;
				}
				else if (nights > 7 && nights <= 200)
				{
					stPrice = 47.5 * nights;
					doPrice = 65 * nights;
					suPrice = 75 * nights;
				}
			}
			else if (month == "june")
			{
				if (nights > 0 && nights <= 14)
				{
					stPrice = 60 * nights;
					doPrice = 72 * nights;
					suPrice = 82 * nights;
				}
				else if (nights > 14 && nights <= 200)
				{
					stPrice = 60 * nights;
					doPrice = 64.8 * nights;
					suPrice = 82 * nights;
				}
			}
			else if (month == "july" || month == "august" || month == "december")
			{
				if (nights > 0 && nights <= 14)
				{
					stPrice = 68 * nights;
					doPrice = 77 * nights;
					suPrice = 89 * nights;
				}
				else if (nights > 14 && nights <= 200)
				{
					stPrice = 68 * nights;
					doPrice = 77 * nights;
					suPrice = 75.65 * nights;
				}
			}
			else if (month == "september")
			{
				if (nights > 0 && nights <= 7)
				{
					stPrice = 60 * nights;
					doPrice = 72 * nights;
					suPrice = 82 * nights;
				}
				else if (nights > 7 && nights <= 14)
				{
					stPrice = 60 * (nights - 1);
					doPrice = 72 * nights;
					suPrice = 82 * nights;
				}
				else if (nights > 14 && nights <= 200)
				{
					stPrice = 60 * (nights - 1);
					doPrice = 64.8 * nights;
					suPrice = 82 * nights;
				}
			}
			else if (month == "october")
			{
				if (nights > 0 && nights <= 7)
				{
					stPrice = 50 * nights;
					doPrice = 65 * nights;
					suPrice = 75 * nights;
				}
				else if (nights > 7 && nights <= 200)
				{
					stPrice = 47.5 * (nights - 1);
					doPrice = 65 * nights;
					suPrice = 75 * nights;
				}
			}
			Console.WriteLine($"Studio: {stPrice:F2} lv.");
			Console.WriteLine($"Double: {doPrice:F2} lv.");
			Console.WriteLine($"Suite: {suPrice:F2} lv.");
		}
	}
}