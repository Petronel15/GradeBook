using System;
using Xunit;
using System.Collections.Generic;
using GradeBook;

namespace GradeBook
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            //Arrange 
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.1);
            book.AddGrade(77.5);

            //Act
            var result = book.ShowStatistics();

            //Assert
            Assert.Equal(85.6, result.Average);
            Assert.Equal(90.1, result.High);
            Assert.Equal(77.5, result.Low);
        }
    }
}
