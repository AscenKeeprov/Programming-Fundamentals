using System;

namespace CenturiesToMinutes
{
	class Program
	{
		static void Main(string[] args)
		{
			byte centuries = byte.Parse(Console.ReadLine());
			ushort years = (ushort)(100 * centuries);
			uint days = (uint)(years * 365.2422);
			uint hours = days * 24;
			ulong minutes = hours * 60;
			Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
		}
	}
}