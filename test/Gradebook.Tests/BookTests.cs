using System;
using Xunit;


namespace Gradebook.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void BookTests()
        {
            //Typically, tests are split into three sections.

            //1. Arrange This is where you put your test data and arrange the data that you want to test
           var book = new Book("");
           book.AddGrade(89.1);
           book.AddGrade(90.5);
           book.AddGrade(77.3);



            //Act section - where you invoke a method to actually do something that produces an actual result

            var result = book.GetStatistics();

            //Assert section - where you assert something about the value in act.

            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);

            // Assert.Equal(expectedResult, actualResult);

        }
    }
}
