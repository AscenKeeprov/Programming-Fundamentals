using System;

namespace BackIn30Min
{
	class Program
	{
		static void Main(string[] args)
		{
			int hours = int.Parse(Console.ReadLine());
			int minutes = int.Parse(Console.ReadLine());
			minutes += 30;
			if (minutes > 59)
			{
				hours += 1;
				if (hours > 23) hours -= 24;
				minutes -= 60;
			}
			Console.WriteLine($"{hours}:{minutes:D2}");
		}
	}
}