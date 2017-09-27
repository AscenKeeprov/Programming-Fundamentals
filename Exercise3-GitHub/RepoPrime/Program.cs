using System;

namespace Program
{
	class Startup
	{
		static void Main(string[] args)
		{
			Console.Write("Please enter your name: ");
			string name = Console.ReadLine().Trim();
			Console.WriteLine($"░░▒▒▓▓ Welcome to GitHub, {name}! ▓▓▒▒░░");
		}
	}
}