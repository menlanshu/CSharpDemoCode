using System;
using Xunit;
using UnitTestDemoLibrary;

namespace UnitTestDemo
{
    public class TestCalculator
    {
        [Fact]
        public void Add_SimpleNormalCase()
        {
            // Arrange
            Calculator testObject = new Calculator();
            double expected = 5;

            // Act
            double actual = testObject.Add(2, 3);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 5 ,9)]
        [InlineData(5, 5 ,10)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void Add_SimpleTheoryTest(double x, double y, double expected)
        {
            // Arrange
            Calculator testObject = new Calculator();

            // Act
            double actual = testObject.Add(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 0, 0)]
        public void Divide_DivideZeroTest(double x, double y, double expected)
        {
            // Arrange
            Calculator testObject = new Calculator();

            // Act
            double actual = testObject.Divide(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
