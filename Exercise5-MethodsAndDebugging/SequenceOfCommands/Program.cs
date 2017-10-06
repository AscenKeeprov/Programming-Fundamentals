using System;
using System.Linq;

namespace SequenceOfCommands
{
	class Program
	{
		static long[] PerformActionCalc(long[] numbersArray, string action, int[] parameters)
		{
			int position = parameters[0] - 1;
			int value = parameters[1];
			switch (action)
			{
				case "add":
					numbersArray[position] += value;
					break;
				case "subtract":
					numbersArray[position] -= value;
					break;
				case "multiply":
					numbersArray[position] *= value;
					break;
			}
			return numbersArray;
		}

		static long[] PerformActionShift(long[] numbersArray, string action)
		{
			switch (action)
			{
				case "rshift":
					numbersArray = ArrayShiftRight(numbersArray);
					break;
				case "lshift":
					numbersArray = ArrayShiftLeft(numbersArray);
					break;
			}
			return numbersArray;
		}

		private static long[] ArrayShiftRight(long[] numbersArray)
		{
			long arrayEnd = numbersArray[numbersArray.Length - 1];
			for (int i = numbersArray.Length - 1; i >= 1; i--) numbersArray[i] = numbersArray[i - 1];
			numbersArray[0] = arrayEnd;
			return numbersArray;
		}

		private static long[] ArrayShiftLeft(long[] numbersArray)
		{
			long arrayStart = numbersArray[0];
			for (int i = 0; i < numbersArray.Length - 1; i++) numbersArray[i] = numbersArray[i + 1];
			numbersArray[numbersArray.Length - 1] = arrayStart;
			return numbersArray;
		}

		private static void PrintArray(long[] numbersArray)
		{
			for (int i = 0; i < numbersArray.Length; i++) Console.Write($"{numbersArray[i]} ");
			Console.WriteLine();
		}

		public static void Main()
		{
			byte numbersCount = byte.Parse(Console.ReadLine());
			long[] numbersArray = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
			string[] command = Console.ReadLine().Trim().ToLower().Split(' ').ToArray();
			string action = command[0];
			while (action != "stop")
			{
				long[] modifiedArray = numbersArray.Clone() as long[];
				if (action == "add" || action == "subtract" || action == "multiply")
				{
					int[] parameters = new int[2];
					parameters[0] = int.Parse(command[1]);
					parameters[1] = int.Parse(command[2]);
					modifiedArray = PerformActionCalc(numbersArray, action, parameters);
				}
				else if (action == "rshift" || action == "lshift") modifiedArray = PerformActionShift(numbersArray, action);
				PrintArray(modifiedArray);
				command = Console.ReadLine().Trim().ToLower().Split(' ').ToArray();
				action = command[0];
			}
		}
	}
}