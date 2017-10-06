using System;

namespace NumbersInReversedOrder
{
	class Program
	{
		static string ReverseDigits(double number)
		{
			string reverseNumber = "";
			if (number < 0) reverseNumber += '-';
			string numero = Math.Abs(number).ToString();
			int stringLength = numero.Length;
			for (int d = 1; d <= stringLength; d++)
			{
				char lastDigit = numero[numero.Length - 1];
				reverseNumber += lastDigit;
				numero = numero.Remove(numero.Length - 1);
			}
			return reverseNumber;
		}

		static void Main(string[] args)
		{
			double number = double.Parse(Console.ReadLine());
			Console.WriteLine(ReverseDigits(number));
		}
	}
}