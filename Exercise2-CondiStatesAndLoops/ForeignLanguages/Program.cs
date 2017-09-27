using System;

namespace ForeignLanguages
{
	class Program
	{
		static void Main(string[] args)
		{
			string country = Console.ReadLine().Trim().ToLower();
			if (country == "england" || country == "usa") Console.WriteLine("English");
			else if (country == "spain" || country == "argentina" || country == "mexico") Console.WriteLine("Spanish");
			else Console.WriteLine("unknown");
		}
	}
}