using System;
using System.Collections.Generic;
using Xunit;

namespace Statistics.Tests
{
    public class AverageTest
    {
        [Fact]
        public void TestMeanOfTwoNumbers()
        {
            //arrange
            List<int> numbers = new List<int> { 1, 4 };
            double expected = 2.5;
            Average testee = new Average();
            //act
            double actual = testee.Mean(numbers);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanWithNoNumbers()
        {
            //arrange
            List<int> numbers = new List<int> {};
            Average testee = new Average();
            //act
            //assert
            Assert.Throws<ArgumentException>(()=> testee.Mean(numbers));
        }
    }
}
