using System;

namespace TheaThePhotographer
{
	class Program
	{
		static void Main(string[] args)
		{
			uint picturesTaken = uint.Parse(Console.ReadLine());
			uint filterTimeInSec = uint.Parse(Console.ReadLine());
			byte filterFactorPCT = byte.Parse(Console.ReadLine());
			uint uploadTimeInSec = uint.Parse(Console.ReadLine());
			uint picturesFiltered = (uint)Math.Ceiling((double)picturesTaken * filterFactorPCT / 100);
			ulong totalTimeInSec = (ulong)picturesTaken * (ulong)filterTimeInSec + (ulong)picturesFiltered * (ulong)uploadTimeInSec;
			Console.WriteLine(TimeSpan.FromSeconds(totalTimeInSec).ToString(@"d\:hh\:mm\:ss"));
		}
	}
}