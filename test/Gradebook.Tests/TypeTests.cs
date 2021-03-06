using System;
using Xunit;


namespace Gradebook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);

        // We can check if two objects are not the same instance.

            Assert.NotSame(book1, book2);




        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            // Assert.Equal("Book 1", book2.Name);


            //We can check if 2 objects (book1 and book2), point to the same instance.

            Assert.Same(book1, book2);
            //OR
            Assert.True(Object.ReferenceEquals(book1, book2));

        }

        Book GetBook(string name)
        {
            return new Book(name);

           
        }




}

}