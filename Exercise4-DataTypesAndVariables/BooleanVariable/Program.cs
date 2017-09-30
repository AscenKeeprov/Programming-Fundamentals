using System;

namespace BooleanVariable
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine().Trim();
			bool isBool = Convert.ToBoolean(input);
			if (isBool) Console.WriteLine("Yes");
			else Console.WriteLine("No");
		}
	}
}