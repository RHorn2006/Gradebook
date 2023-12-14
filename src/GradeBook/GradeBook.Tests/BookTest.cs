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
        Assert.AreEqual(85.6, result.Average);
        Assert.AreEqual(90.5, result.High);
        Assert.AreEqual(77.3, result.Low);
    }
}