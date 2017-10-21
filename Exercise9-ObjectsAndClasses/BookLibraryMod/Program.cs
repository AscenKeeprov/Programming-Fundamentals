using System;
using System.Collections.Generic;
using System.Globalization;
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
	    int n = int.Parse(Console.ReadLine());
	    for (int i = 1; i <= n; i++)
	    {
		string[] input = Console.ReadLine()
		    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
		Book book = new Book()
		{
		    Title = input[0],
		    Author = input[1],
		    Publisher = input[2],
		    ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
		    ISBN = input[4],
		    Price = double.Parse(input[5])
		};
		library.Books.Add(book);
	    }
	    DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
	    foreach (Book book in library.Books
		.Where(b => b.ReleaseDate > startDate)
		.OrderBy(b => b.ReleaseDate)
		.ThenBy(b => b.Title))
		Console.WriteLine($"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}");
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