using System;

namespace VariableInHexFormat
{
	class Program
	{
		static void Main(string[] args)
		{
			string hexadecaNum = Console.ReadLine();
			int decaNum = Convert.ToInt32(hexadecaNum, 16);
			Console.WriteLine(decaNum);
		}
	}
}