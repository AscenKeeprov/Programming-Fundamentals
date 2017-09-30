using System;

namespace PrintPartOfASCIITable
{
	class Program
	{
		static void Main(string[] args)
		{
			byte startCharCode = byte.Parse(Console.ReadLine());
			byte endCharCode = byte.Parse(Console.ReadLine());
			for (char symbol = Convert.ToChar(startCharCode); symbol <= Convert.ToChar(endCharCode); symbol++) Console.Write($"{symbol} ");
			Console.WriteLine();
		}
	}
}