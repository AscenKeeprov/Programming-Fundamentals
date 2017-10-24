using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
	    string[] input = File.ReadAllLines("inputBL.txt");
	    if (File.Exists("outputBL.txt")) File.Delete("outputBL.txt");
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
		if (!library.Catalogue.ContainsKey(book.Author))
		    library.Catalogue.Add(book.Author, book.Price);
		else library.Catalogue[book.Author] += book.Price;
	    }
	    foreach (var author in library.Catalogue
		.OrderByDescending(price => price.Value)
		.ThenBy(author => author.Key))
		File.AppendAllText("outputBL.txt", $"{author.Key} -> " +
		    $"{author.Value:F2}{Environment.NewLine}");
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