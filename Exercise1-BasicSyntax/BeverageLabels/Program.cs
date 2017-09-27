using System;

namespace BeverageLabels
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			int vol = int.Parse(Console.ReadLine());
			int nrg100 = int.Parse(Console.ReadLine());
			int suga100 = int.Parse(Console.ReadLine());
			double nrgVol = (nrg100 * vol) / 100.00;
			double sugaVol = (suga100 * vol) / 100.00;
			Console.WriteLine($"{vol}ml {name}:");
			Console.WriteLine($"{nrgVol}kcal, {sugaVol}g sugars");
		}
	}
}