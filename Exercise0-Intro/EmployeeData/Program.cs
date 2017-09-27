using System;

namespace EmployeeData
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			var age = int.Parse(Console.ReadLine());
			var ID = int.Parse(Console.ReadLine());
			var salary = double.Parse(Console.ReadLine());
			Console.WriteLine($"Name: {name}");
			Console.WriteLine($"Age: {age}");
			Console.WriteLine($"Employee ID: {ID:D8}");
			Console.WriteLine($"Salary: {salary:F2}");
		}
	}
}