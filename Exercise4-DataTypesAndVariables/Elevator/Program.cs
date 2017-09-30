using System;

namespace Elevator
{
	class Program
	{
		static void Main(string[] args)
		{
			byte countOfPassengers = byte.Parse(Console.ReadLine());
			byte elevatorCapacity = byte.Parse(Console.ReadLine());
			byte elevatorCourses = (byte)Math.Ceiling(1.0 * countOfPassengers / elevatorCapacity);
			Console.WriteLine(elevatorCourses);
		}
	}
}