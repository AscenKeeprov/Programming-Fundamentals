using System;

namespace EmployeeData
{
	class Program
	{
		static void Main(string[] args)
		{
			string firstName = Console.ReadLine().Trim();
			string lastName = Console.ReadLine().Trim();
			byte age = byte.Parse(Console.ReadLine());
			char gender = char.Parse(Console.ReadLine());
			ulong personalNumber = ulong.Parse(Console.ReadLine());
			uint employeeNumber = uint.Parse(Console.ReadLine());
			Console.WriteLine($"First name: {firstName}");
			Console.WriteLine($"Last name: {lastName}");
			Console.WriteLine($"Age: {age}");
			Console.WriteLine($"Gender: {gender}");
			Console.WriteLine($"Personal ID: {personalNumber}");
			Console.WriteLine($"Unique Employee number: {employeeNumber}");
		}
	}
}