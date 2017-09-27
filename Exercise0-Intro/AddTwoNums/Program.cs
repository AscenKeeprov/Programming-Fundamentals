using System;

namespace AddTwoNums
{
	class Program
	{
		static void Main(string[] args)
		{
			var num1 = int.Parse(Console.ReadLine());
			var num2 = int.Parse(Console.ReadLine());
			var sum = num1 + num2;
			Console.WriteLine($"{num1} + {num2} = {sum}");
		}
	}
}