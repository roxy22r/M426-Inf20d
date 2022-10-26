using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAddThreeToTwoPIsFive()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int expected = 5;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void TestSubtractFourFromSixIsTwo()
        {
            // Given
            int a = 6;
            int b = 4;
            int expected = 2;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Subtract(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiplyFiveMultiplySixIsThirty()
        {
            // Given
            int a = 5;
            int b = 6;
            int expected = 30;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Multiply (a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiplyFiveMultiplySevenIsNotThirty()
        {
            // Given
            int a = 5;
            int b = 7;
            int expected = 30;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Multiply(a, b);

            // Then
            Assert.NotEqual (expected, actual);
        }


        [Fact]
        public void TestDivisionTenDivideByTwoIsFive()
        {
            // Given
            int a = 10;
            int b = 2;
            int expected = 5;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Division (a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivisionZeroDivideByTwoThrowException()
        {
            // Given
            int a = 5;
            int b = 0;
            Calculator calculator = new Calculator();

            // When

            // Then
            Assert.Throws<ArgumentException >(()=> calculator.Division(a, b));
        }


    }
}
