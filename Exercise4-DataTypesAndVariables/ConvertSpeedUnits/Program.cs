using System;

namespace ConvertSpeedUnits
{
	class Program
	{
		static void Main(string[] args)
		{
			uint meters = uint.Parse(Console.ReadLine());
			byte hours = byte.Parse(Console.ReadLine());
			byte minutes = byte.Parse(Console.ReadLine());
			byte seconds = byte.Parse(Console.ReadLine());
			ushort sumSeconds = (ushort)((hours * 3600) + (minutes * 60) + seconds);
			float speedMperS = (float)meters / sumSeconds;
			float speedKMperH = ((float)meters / 1000) / ((float)sumSeconds / 3600);
			float speedMIperH = ((float)meters / 1609) / ((float)sumSeconds / 3600);
			Console.WriteLine($"{speedMperS:0.#######}");
			Console.WriteLine($"{speedKMperH:0.#######}");
			Console.WriteLine($"{speedMIperH:0.#######}");
		}
	}
}