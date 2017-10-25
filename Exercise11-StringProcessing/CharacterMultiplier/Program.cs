using System;

namespace CharacterMultiplier
{
    class Program
    {
	static void Main()
	{
	    string[] input = Console.ReadLine().Split();
	    int result = MultiplyCharacters(input[0], input[1]);
	    Console.WriteLine(result);
	}

	static int MultiplyCharacters(string input1, string input2)
	{
	    if (input1.Length < input2.Length)
	    {
		string temp = input1;
		input1 = input2;
		input2 = temp;
	    }
	    int result = 0;
	    for (int i = 0; i < input1.Length; i++)
	    {
		if (i < input2.Length) result += input1[i] * input2[i];
		else result += input1[i];
	    }
	    return result;
	}
    }
}