using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            var book = new Book("Martin");

            book.AddGrade(40.74);
            book.AddGrade(80.74);
            book.AddGrade(99.74);
            book.showStatistics();

            Assert.Equal(74, Math.Round(book.averageGrade));
            Assert.Equal("Martin", book.name);



        }
    }
}
