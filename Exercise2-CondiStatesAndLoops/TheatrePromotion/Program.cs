using System;

namespace TheatrePromotion
{
	class Program
	{
		static void Main(string[] args)
		{
			string dayType = Console.ReadLine().Trim().ToLower();
			int age = int.Parse(Console.ReadLine());
			double price = 0;
			if (age >= 0 && age <= 18)
			{
				if (dayType == "weekday") price = 12;
				else if (dayType == "weekend") price = 15;
				else if (dayType == "holiday") price = 5;
			}
			else if (age > 18 && age <= 64)
			{
				if (dayType == "weekday") price = 18;
				else if (dayType == "weekend") price = 20;
				else if (dayType == "holiday") price = 12;
			}
			else if (age > 64 && age <= 122)
			{
				if (dayType == "weekday") price = 12;
				else if (dayType == "weekend") price = 15;
				else if (dayType == "holiday") price = 10;
			}
			else
			{
				Console.WriteLine("Error!");
				return;
			}
			Console.WriteLine($"{price}$");
		}
	}
}