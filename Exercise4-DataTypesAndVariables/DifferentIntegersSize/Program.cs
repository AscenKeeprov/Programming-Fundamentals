using System;

namespace DifferentIntegersSize
{
	class Program
	{
		static void Main(string[] args)
		{
			string number = Console.ReadLine();
			if (!long.TryParse(number, out long fitsLong)) Console.WriteLine($"{number} can't fit in any type");
			else
			{
				Console.WriteLine($"{number} can fit in:");
				if (sbyte.TryParse(number, out sbyte fitsSbyte)) Console.WriteLine("* sbyte");
				if (byte.TryParse(number, out byte fitsByte)) Console.WriteLine("* byte");
				if (short.TryParse(number, out short fitsShort)) Console.WriteLine("* short");
				if (ushort.TryParse(number, out ushort fitsUshort)) Console.WriteLine("* ushort");
				if (int.TryParse(number, out int fitsInt)) Console.WriteLine("* int");
				if (uint.TryParse(number, out uint fitsUint)) Console.WriteLine("* uint");
				Console.WriteLine("* long");
			}
		}
	}
}