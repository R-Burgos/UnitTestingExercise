using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(4, 9, 1, 14)]
        [InlineData(6, 10, 1, 17)]
        [InlineData(7, 11, 1, 19)]
        [InlineData(8, 12, 1, 21)]
        [InlineData(0, 1, 0, 1)]
        [InlineData(-1, 1, 0, 0)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator calculator = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calculator.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]//Add test data <-------
        [InlineData(1, 1, 0)]
        [InlineData(2, 1, 1)]
        [InlineData(20, 10, 10)]
        [InlineData(-1, 3, -4)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator calculator = new Calculator();
            //Act
            var actual = calculator.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 1)]//Add test data <-------
        [InlineData(5, 5, 25)]
        [InlineData(10, 10, 100)]
        [InlineData(-6, 6, -36)]
        [InlineData(17, 0, 0)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator calculator = new Calculator();
            //Act
            var actual = calculator.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 4, 1)]//Add test data <-------
        [InlineData(10, 5, 2)]
        [InlineData(100, 10, 10)]
        [InlineData(64, 8, 8)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calculator = new Calculator();
            //Act
            var actual = calculator.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
