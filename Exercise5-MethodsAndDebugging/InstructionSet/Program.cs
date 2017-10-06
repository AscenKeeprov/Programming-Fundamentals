using System;

namespace InstructionSet
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			while (input != "END")
			{
				string[] codeArgs = input.Split(' ');
				string operatOr = codeArgs[0];
				long result = 0;
				switch (operatOr)
				{
					case "INC":
						int operand1 = int.Parse(codeArgs[1]);
						result = (long)operand1 + 1;
						break;
					case "DEC":
						operand1 = int.Parse(codeArgs[1]);
						result = (long)operand1 - 1;
						break;
					case "ADD":
						operand1 = int.Parse(codeArgs[1]);
						int operand2 = int.Parse(codeArgs[2]);
						result = (long)operand1 + operand2;
						break;
					case "MLA":
						operand1 = int.Parse(codeArgs[1]);
						operand2 = int.Parse(codeArgs[2]);
						result = (long)operand1 * operand2;
						break;
				}
				Console.WriteLine(result);
				input = Console.ReadLine();
			}
		}
	}
}