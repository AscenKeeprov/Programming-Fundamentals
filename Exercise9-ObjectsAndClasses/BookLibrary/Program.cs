using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BookLibrary
{
    class Program
    {
	static void Main()
	{
	    Library library = new Library()
	    {
		Name = "Classics",
		Books = new List<Book>(),
		Catalogue = new Dictionary<string, double>()
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
		if (!library.Catalogue.ContainsKey(book.Author)) library.Catalogue.Add(book.Author, book.Price);
		else library.Catalogue[book.Author] += book.Price;
	    }
	    foreach (var author in library.Catalogue
		.OrderByDescending(price => price.Value)
		.ThenBy(author => author.Key))
		Console.WriteLine($"{author.Key} -> {author.Value:f2}");
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
	public Dictionary<string, double> Catalogue { get; set; }
    }
}