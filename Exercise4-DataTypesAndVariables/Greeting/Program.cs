using System;

namespace Greeting
{
	class Program
	{
		static void Main(string[] args)
		{
			string firstName = Console.ReadLine().Trim();
			string lastName = Console.ReadLine().Trim();
			byte age = byte.Parse(Console.ReadLine());
			Console.WriteLine($"Hello, {firstName} {lastName}. You are {age} years old.");
		}
	}
}