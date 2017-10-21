using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MentorGroup
{
    class Program
    {
	static void Main()
	{
	    List<Student> group = new List<Student>();
	    string inputDate = Console.ReadLine();
	    while (inputDate.Trim().ToUpper() != "END OF DATES")
	    {
		Student member = new Student()
		{
		    Name = inputDate.Split(' ')[0],
		    Attendancies = inputDate.Split(' ', ',').Skip(1)
		    .Select(d => DateTime.ParseExact(d, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList(),
		    Comments = new List<string>()
		};
		if (!group.Any(m => m.Name == member.Name)) group.Add(member);
		else
		{
		    Student existingMember = group.First(m => m.Name == member.Name);
		    existingMember.Attendancies.AddRange(member.Attendancies);
		}
		inputDate = Console.ReadLine();
	    }
	    string inputComment = Console.ReadLine();
	    while (inputComment.Trim().ToUpper() != "END OF COMMENTS")
	    {
		Student member = new Student()
		{
		    Name = inputComment.Split('-')[0],
		    Comments = new List<string> { inputComment.Split('-')[1] }
		};
		if (group.Any(m => m.Name == member.Name))
		{
		    Student evaluatedMember = group.First(m => m.Name == member.Name);
		    evaluatedMember.Comments.AddRange(member.Comments);
		}
		inputComment = Console.ReadLine();
	    }
	    foreach (Student member in group.OrderBy(m => m.Name))
	    {
		Console.WriteLine($"{member.Name}{Environment.NewLine}Comments:");
		foreach (string comment in member.Comments)
		    Console.WriteLine($"- {comment}");
		Console.WriteLine($"Dates attended:");
		foreach (DateTime date in member.Attendancies.OrderBy(d => d.Date))
		    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}");
	    }
	}
    }

    class Student
    {
	public string Name { get; set; }
	public List<DateTime> Attendancies { get; set; }
	public List<string> Comments { get; set; }
    }
}