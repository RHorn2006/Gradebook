namespace GradeBook.Tests
{
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
            book.AddGrade(77);
            book.AddGrade(65.3);

            // act
            var result = book.ShowStatistics();

            // assert
            Assert.AreEqual(85.6, result.Average);
            Assert.AreEqual(89.1, result.High);
            Assert.AreEqual(65.3, result.Low);
        }
}
}