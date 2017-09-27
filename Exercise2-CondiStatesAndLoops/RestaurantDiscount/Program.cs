using System;

namespace RestaurantDiscount
{
	class Program
	{
		static void Main(string[] args)
		{
			int guests = int.Parse(Console.ReadLine());
			string package = Console.ReadLine().ToLower();
			string location = "We do not have an appropriate hall.";
			double price = 0.00;
			double discount = 0.00;
			if (guests >= 1 && guests <= 50)
			{
				location = "Small Hall";
				price += 2500;
			}
			else if (guests > 50 && guests <= 100)
			{
				location = "Terrace";
				price += 5000;
			}
			else if (guests > 100 && guests <= 120)
			{
				location = "Great Hall";
				price += 7500;
			}
			else
			{
				Console.WriteLine(location);
				return;
			}
			if (package == "normal")
			{
				price += 500;
				discount = 0.05;
			}
			else if (package == "gold")
			{
				price += 750;
				discount = 0.1;
			}
			else if (package == "platinum")
			{
				price += 1000;
				discount = 0.15;
			}
			double singlePrice = (price - (price * discount)) / guests;
			Console.WriteLine($"We can offer you the {location}");
			Console.WriteLine($"The price per person is {singlePrice:F2}$");
		}
	}
}