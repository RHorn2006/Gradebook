using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Emit;

namespace GradeBook;

class Program
{
    static void Main(string[] args)
    {
        var book = new Book();
        book.AddGrade(67.5);
        book.AddGrade(45.7);

        List<double> grades = new List<double>() { 64.5, 45.3, 62.6 };
        grades.Add(56.1);
        
        var result = 0.0;
        foreach (double number in grades)
        {
            result += number;
        }
        result /= grades.Count;
        Console.WriteLine($"The average grade is {result:0.00000}");
    }
}
