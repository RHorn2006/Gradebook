using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Emit;

namespace GradeBook;

class Program
{
    static void Main(string[] args)
    {
        var book = new Book("Scott's Grade Book");
        book.AddGrade(67.5);
        book.AddGrade(45.7);
        book.AddGrade(34.7);

        var stats = book.GetStatistics();
        Console.WriteLine($"The average grade is {stats.Average}, the lowest grade is {stats.Low} and the highest grade is {stats.High}");
    }
}
