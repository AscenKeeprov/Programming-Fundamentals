using System;

namespace IntToHexAndBin
{
	class Program
	{
		static void Main(string[] args)
		{
			ushort decaNum = ushort.Parse(Console.ReadLine());
			string hexadecaNum = decaNum.ToString("X");
			string diNum = Convert.ToString(decaNum, 2);
			Console.WriteLine(hexadecaNum);
			Console.WriteLine(diNum);
		}
	}
}