using System;
using System.Collections.Generic;
using System.Linq;

namespace AndreyAndBilliard
{
    class Program
    {
	static void Main()
	{
	    Dictionary<string/*product*/, double/*price*/> menu = new Dictionary<string, double>();
	    List<Customer> tabs = new List<Customer>();
	    int n = int.Parse(Console.ReadLine());
	    for (int i = 1; i <= n; i++)
	    {
		string[] menuItem = Console.ReadLine()
		    .Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
		string product = menuItem[0];
		double price = double.Parse(menuItem[1]);
		if (!menu.ContainsKey(product)) menu.Add(product, price);
		else menu[product] = price;
	    }
	    string[] order = Console.ReadLine()
		    .Split(new char[] { '-', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
	    while (order[0].ToUpper() != "END")
	    {
		string product = order[1];
		if (menu.ContainsKey(product))
		{
		    Customer customer = new Customer()
		    {
			Name = order[0],
			Order = new Dictionary<string, int>(),
		    };
		    int quantity = int.Parse(order[2]);
		    customer.Order.Add(product, quantity);
		    double price = menu[product];
		    customer.Bill = quantity * price;
		    if (!tabs.Any(c => c.Name == customer.Name)) tabs.Add(customer);
		    else
		    {
			Customer existingCustomer = tabs.First(c => c.Name == customer.Name);
			if (!existingCustomer.Order.ContainsKey(product))
			    existingCustomer.Order.Add(product, quantity);
			else existingCustomer.Order[product] += quantity;
			existingCustomer.Bill += customer.Bill;
		    }
		}
		order = Console.ReadLine()
		    .Split(new char[] { '-', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
	    }
	    double totalBill = 0;
	    foreach (var customer in tabs.OrderBy(customer => customer.Name))
	    {
		Console.WriteLine($"{customer.Name}");
		foreach (var product in customer.Order)
		    Console.WriteLine($"-- {product.Key} - {product.Value}");
		Console.WriteLine($"Bill: {customer.Bill:F2}");
		totalBill += customer.Bill;
	    }
	    Console.WriteLine($"Total bill: {totalBill:F2}");
	}
    }

    class Customer
    {
	public string Name { get; set; }
	public Dictionary<string/*product*/, int/*quantity*/> Order { get; set; }
	public double Bill { get; set; }
    }
}