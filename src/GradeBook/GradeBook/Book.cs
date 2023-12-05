namespace GradeBook;
class Book
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

    public void ShowStatistics()
    {
        var result = 0.0;
        var lowGrade = double.MaxValue;
        var highGrade = double.MinValue;
        foreach (double number in grades)
        {
            if (number > highGrade)
            {
                highGrade = Math.Max(number, highGrade);
                result += number;
            }
            else if (number < lowGrade)
            {
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }

        }
        result /= grades.Count;
        Console.WriteLine($"The average grade is {result:0.00000}, the lowest grade is {lowGrade} and the highest grade is {highGrade}");
    }
    private List<double> grades;
    private string name;
}
