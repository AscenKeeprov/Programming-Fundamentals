using System;

namespace IntegersCounter
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = null;
			int counter = 0;
			int result;
			do
			{
				input = Console.ReadLine();
				if (int.TryParse(input, out result)) counter++;
			}
			while (int.TryParse(input, out result));
			Console.WriteLine(counter);
		}
	}
}