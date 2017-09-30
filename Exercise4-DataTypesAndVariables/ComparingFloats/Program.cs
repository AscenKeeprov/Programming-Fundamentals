using System;

namespace ComparingFloats
{
	class Program
	{
		static void Main(string[] args)
		{
			double number1 = double.Parse(Console.ReadLine());
			double number2 = double.Parse(Console.ReadLine());
			double numberDiff = Math.Abs(number1 - number2);
			bool numbersEqual = true;
			if (numberDiff >= 0.000001) numbersEqual = false;
			Console.WriteLine(numbersEqual);
		}
	}
}