namespace GradeBook.Tests;

public class TypeTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void BookOverwriteName()
    {
        var book1 = GetBook("Book 1");
        SetName(book1, "New Name");

        Assert.That(book1.Name, Is.EqualTo("New Name"));
    }

    private void SetName(Book book, string name)
    {
        book.Name = name;
    }


    [Test]
    public void GetBookReturnsDifferentObjects()
    {
        var book1 = GetBook("Book 1");
        var book2 = GetBook("Book 2");

        Assert.That(book1.Name, Is.EqualTo("Book 1"));
        Assert.That(book2.Name, Is.EqualTo("Book 2"));
    }

    [Test]
    public void TwoVarsCanReferenceSameObject()
    {
        var book1 = GetBook("Book 1");
        var book2 = book1;

        Assert.That(book2, Is.Not.SameAs(book1));
        Assert.True(Object.ReferenceEquals(book1, book2));
    }

    Book GetBook(string name)
    {
        return new Book(name);
    }
}