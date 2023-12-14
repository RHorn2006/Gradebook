namespace GradeBook.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void BookTest()
    {
        // arrange
        var book = new Book("");
        book.AddGrade(89.1);
        book.AddGrade(90.5);
        book.AddGrade(77.3);

        // act
        var result = book.GetStatistics();

        // assert
        Assert.That(result.Average, Is.EqualTo(85.6));
        Assert.That(result.High, Is.EqualTo(90.5));
        Assert.That(result.Low, Is.EqualTo(77.3));
        Assert.That(result.Letter, Is.EqualTo('B'));
    }
}