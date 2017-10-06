using System;

namespace HelloName
{
	class Program
	{
		static string Greeting(string name)
		{
			string greeting = string.Format($"Hello, {name}!");
			return greeting;
		}

		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			Console.WriteLine(Greeting(name));
		}
	}
}