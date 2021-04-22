using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTest
    {
        [Fact]
        public void UpdateObject()
        {
            string name = "Martin P";
            var book1 = GetBook(name);
            this.SetName(book1, "New Name");
            Assert.NotEqual(name, book1.name);

        }

        private void SetName(Book book, string name)
        {
            book.name = name;
        }


        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Martin P");
            var book2 = GetBook("Martin");

            Assert.Equal("Martin P", book1.name);
            Assert.Equal("Martin", book2.name);

        }


        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
