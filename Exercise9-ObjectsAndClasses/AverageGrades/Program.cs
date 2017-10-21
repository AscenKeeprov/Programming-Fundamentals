using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageGrades
{
    class Program
    {
	static void Main()
	{
	    List<Student> register = new List<Student>();
	    int n = int.Parse(Console.ReadLine());
	    for (int s = 1; s <= n; s++)
	    {
		string[] studentData = Console.ReadLine()
		    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
		Student student = new Student()
		{
		    Name = studentData[0],
		    Grades = studentData.Skip(1).Select(double.Parse).ToList()
		};
		register.Add(student);
	    }
	    foreach (Student student in register
		.Where(s => s.AverageGrade>=5)
		.OrderBy(s => s.Name)
		.ThenByDescending(s => s.AverageGrade))
	    {
		Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
	    }
	}
    }

    class Student
    {
	public string Name { get; set; }
	public List<double> Grades { get; set; }
	public double AverageGrade { get { return Grades.Average(); } }
    }
}