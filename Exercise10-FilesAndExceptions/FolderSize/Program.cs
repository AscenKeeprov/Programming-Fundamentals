using System;
using System.IO;
using System.Linq;

namespace FolderSize
{
    class Program
    {
	static void Main()
	{
	    string[] dirContents = Directory.GetFiles("TestFolder");
	    /*	ALTERNATIVE WAY:
	     * string[] dirContents = Directory
	     * .EnumerateFiles("TestFolder", "*.*", SearchOption.TopDirectoryOnly)
	     * .ToArray();  */
	    double totalSize = 0;
	    foreach (string file in dirContents)
	    {
		FileInfo fileInfo = new FileInfo(file);
		totalSize += fileInfo.Length;
	    }
	    if (File.Exists("outputFS.txt")) File.Delete("outputFS.txt");
	    File.AppendAllText("outputFS.txt", $"{totalSize /= 1048576}");
	    Console.WriteLine(File.ReadAllText("outputFS.txt"));
	}
    }
}