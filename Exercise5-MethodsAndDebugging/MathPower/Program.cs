﻿using System;

namespace MathPower
{
	class Program
	{
		static double MathPower(double number, int power)
		{
			return Math.Pow(number, power);
		}

		static void Main(string[] args)
		{
			double number = double.Parse(Console.ReadLine());
			int power = int.Parse(Console.ReadLine());
			Console.WriteLine(MathPower(number, power));
		}
	}
}