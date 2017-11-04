using System;
using System.Globalization;

namespace CoffeeOrders
{
    class Program
    {
	static void Main()
	{
	    int n = int.Parse(Console.ReadLine());
	    decimal totalBill = PlaceOrders(n);
	    Console.WriteLine($"Total: ${totalBill:F2}");
	}

	static decimal PlaceOrders(int n)
	{
	    decimal totalBill = 0M;
	    for (int i = 0; i < n; i++)
	    {
		decimal capsulePrice = decimal.Parse(Console.ReadLine());
		DateTime orderDate = DateTime.ParseExact(Console.ReadLine(),
		    "d/M/yyyy", CultureInfo.InvariantCulture);
		int capsuleCount = int.Parse(Console.ReadLine());
		int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
		decimal monthlyBill = capsulePrice * capsuleCount * daysInMonth;
		Console.WriteLine($"The price for the coffee is: ${monthlyBill:F2}");
		totalBill += monthlyBill;
	    }
	    return totalBill;
	}
    }
}