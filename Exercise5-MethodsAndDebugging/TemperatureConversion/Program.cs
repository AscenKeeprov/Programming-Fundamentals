using System;

namespace TemperatureConversion
{
	class Program
	{
		static double FahrenheitToCelsius(double degreesF)
		{
			return (degreesF - 32) / 1.8;
		}

		static void Main(string[] args)
		{
			double temperature = double.Parse(Console.ReadLine());
			Console.WriteLine($"{FahrenheitToCelsius(temperature):F2}");
		}
	}
}