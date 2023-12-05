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
        book.GetStatistics();
    }
}
