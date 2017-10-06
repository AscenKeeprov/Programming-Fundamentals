using System;

namespace Substring
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			int printCount = byte.Parse(Console.ReadLine());
			bool hasMatch = false;
			for (int i = 0; i < text.Length; i++)
			{
				if (text[i] == 'p')
				{
					hasMatch = true;
					if (printCount > text.Length - 1 - i) printCount = text.Length - 1 - i;
					string matchedString = text.Substring(i, printCount + 1);
					Console.WriteLine(matchedString);
					i += printCount;
				}
			}
			if (!hasMatch) Console.WriteLine("no");
		}
	}
}