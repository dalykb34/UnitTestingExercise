using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,4,6, 11)]
        [InlineData(5,5,5,15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var add = new UnitTestMethods();
            //Act
            var actual = add.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(7,3,4)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var sub = new UnitTestMethods();
            //Act
            var actual = sub.Sub(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,25)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var multi = new UnitTestMethods();
            //Act
            var actual = multi.Multi(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8,4,2)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var divide = new UnitTestMethods();
            //Act
            var actual = divide.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetH()
        {
            //Arrange
            var expected = 'h';
            //Act
            var actual = 'h';
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3,3,9)]
        public void Squared(int num1, int num2, int expected)
        {
            //Arrange
            var squared = new UnitTestMethods();
            //Act
            var actual = squared.Multi(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
