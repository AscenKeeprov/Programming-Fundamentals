using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MergeFiles
{
    class Program
    {
	static void Main()
	{
	    List<string> file1 = File.ReadAllLines("FileOne.txt").ToList();
	    List<string> file2 = File.ReadAllLines("FileTwo.txt").ToList();
	    int outputSize = file1.Count + file2.Count;
	    if (File.Exists("outputMF.txt")) File.Delete("outputMF.txt");
	    for (int i = 0; i < outputSize; i++)
	    {
		if (i % 2 == 0)
		{
		    if (file1.Count() > 0)
		    {
			File.AppendAllText("outputMF.txt", 
			    file1.First() + Environment.NewLine);
			file1.RemoveAt(0);
		    }
		    else
		    {
			File.AppendAllText("outputMF.txt", 
			    file2.First() + Environment.NewLine);
			file2.RemoveAt(0);
		    }
		}
		else
		{
		    if (file2.Count() > 0)
		    {
			File.AppendAllText("outputMF.txt", 
			    file2.First() + Environment.NewLine);
			file2.RemoveAt(0);
		    }
		    else
		    {
			File.AppendAllText("outputMF.txt", 
			    file1.First() + Environment.NewLine);
			file1.RemoveAt(0);
		    }
		}
	    }
	    Console.WriteLine(File.ReadAllText("outputMF.txt"));
	}
    }
}