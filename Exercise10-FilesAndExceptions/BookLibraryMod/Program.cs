using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace BookLibraryMod
{
    class Program
    {
	static void Main()
	{
	    Library library = new Library()
	    {
		Name = "Classics",
		Books = new List<Book>(),
	    };
	    string[] input = File.ReadAllLines("inputBLM.txt");
	    if (File.Exists("outputBLM.txt")) File.Delete("outputBLM.txt");
	    int n = int.Parse(input[0]);
	    for (int i = 1; i <= n; i++)
	    {
		string[] cover = input[i].Split();
		Book book = new Book()
		{
		    Title = cover[0],
		    Author = cover[1],
		    Publisher = cover[2],
		    ReleaseDate = DateTime.ParseExact(cover[3], 
		    "dd.MM.yyyy", CultureInfo.InvariantCulture),
		    ISBN = cover[4],
		    Price = double.Parse(cover[5])
		};
		library.Books.Add(book);
	    }
	    DateTime startDate = DateTime.ParseExact(input[n + 1], 
		"dd.MM.yyyy", CultureInfo.InvariantCulture);
	    foreach (Book book in library.Books
		.Where(b => b.ReleaseDate > startDate)
		.OrderBy(b => b.ReleaseDate)
		.ThenBy(b => b.Title))
		File.AppendAllText("outputBLM.txt", $"{book.Title} -> " +
		    $"{book.ReleaseDate:dd.MM.yyyy}{Environment.NewLine}");
	}
    }

    public class Book
    {
	public string Title { get; set; }
	public string Author { get; set; }
	public string Publisher { get; set; }
	public DateTime ReleaseDate { get; set; }
	public string ISBN { get; set; }
	public double Price { get; set; }
    }

    public class Library
    {
	public string Name { get; set; }
	public List<Book> Books { get; set; }
    }
}