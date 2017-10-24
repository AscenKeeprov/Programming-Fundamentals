using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AverageGrades
{
    class Program
    {
	static void Main()
	{
	    List<Student> register = new List<Student>();
	    string[] input = File.ReadAllLines("inputAG.txt");
	    if (File.Exists("outputAG.txt")) File.Delete("outputAG.txt");
	    int n = int.Parse(input[0]);
	    for (int s = 1; s <= n; s++)
	    {
		string[] studentData = input[s].Split();
		Student student = new Student()
		{
		    Name = studentData[0],
		    Grades = studentData.Skip(1)
		    .Select(double.Parse).ToList()
		};
		register.Add(student);
	    }
	    foreach (Student student in register
		.Where(s => s.AverageGrade >= 5)
		.OrderBy(s => s.Name)
		.ThenByDescending(s => s.AverageGrade))
		File.AppendAllText("outputAG.txt", $"{student.Name} -> " +
		    $"{student.AverageGrade:F2}{Environment.NewLine}");
	}
    }

    class Student
    {
	public string Name { get; set; }
	public List<double> Grades { get; set; }
	public double AverageGrade { get { return Grades.Average(); } }
    }
}