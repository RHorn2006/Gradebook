using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Emit;

namespace GradeBook;

class Program
{
    static void Main(string[] args)
    {
        var book = new Book("Scott's Grade Book");

        while (true)
        {
            Console.WriteLine("Enter a grade or 'q' to quit");
            var input = Console.ReadLine();
            if (input == "q")
            {
                break;
            }

            try
            {
                var grade = double.Parse(input);
                book.AddGrade(grade);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        var stats = book.GetStatistics();
        Console.WriteLine($"{Book.category}");
        Console.WriteLine($"For the book named {book.Name}");
        Console.WriteLine($"The average grade is {stats.Average}");
        Console.WriteLine($"The lowest grade is {stats.Low}");
        Console.WriteLine($"the highest grade is {stats.High}");
        Console.WriteLine($"The letter grade is {stats.Letter}");
    }
}
