using System;

namespace StringsAndObjects
{
	class Program
	{
		static void Main(string[] args)
		{
			string text1 = "Hello";
			string text2 = "World";
			object concatText1Text2 = text1 + " " + text2;
			string concatenatedText = (string)concatText1Text2;
			Console.WriteLine(concatenatedText);
		}
	}
}