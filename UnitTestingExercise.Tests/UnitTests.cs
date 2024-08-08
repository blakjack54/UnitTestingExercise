using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] // Add test data
        [InlineData(1, 1, 1, 3)]
        [InlineData(-1, -2, -3, -6)]
        [InlineData(0, 0, 0, 0)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            // Start Step 3 here:

            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Add(num1, num2, num3);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)] // Add test data
        [InlineData(0, 0, 0)]
        [InlineData(-1, -1, 0)]
        [InlineData(100, 50, 50)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            // Start Step 5 here:

            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Subtract(minuend, subtrahend);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)] // Add test data
        [InlineData(0, 100, 0)]
        [InlineData(-1, -1, 1)]
        [InlineData(7, 8, 56)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            // Start Step 7 here:

            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Multiply(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 5)] // Add test data
        [InlineData(100, 10, 10)]
        [InlineData(-20, -5, 4)]
        [InlineData(9, 3, 3)]
        public void DivideTest(int num1, int num2, int expected)
        {
            // Start Step 9 here:

            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Divide(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
