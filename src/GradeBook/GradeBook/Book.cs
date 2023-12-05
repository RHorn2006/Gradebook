namespace GradeBook;
public class Book
{
    public Book(string name)
    {
        grades = new List<double>();
        this.name = name;
    }

    public void AddGrade(double grade)
    {
        grades.Add(grade);
    }

    public Statistics GetStatistics()
    {
        var result = new Statistics();
        result.Average = 0.0;
        result.High = double.MaxValue;
        result.Low = double.MinValue;
        foreach (double number in grades)
        {
            if (number > result.High)
            {result.High = Math.Max(number, result.High);
                result += number;
            }
            else if (number < result.Low)
            {
                result.Low = Math.Min(number, result.Low);
                result += number;
            }

        }
        result /= grades.Count;
        Console.WriteLine($"The average grade is {result:0.00000}, the lowest grade is {result.Low} and the highest grade is {result.High}");
    }
    private List<double> grades;
    private string name;
}
