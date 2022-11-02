using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
      
       [Fact]
        public void Determine_DivideByThree_ReturnFoo()
        {
            //arrange
            FooBarQixDeterminer testee = new FooBarQixDeterminer();
            //act
            string actual = testee.Determine(3);
            //assert
            Assert.Equal("Foo", actual);
        }
        [Fact]
        public void Determine_DivideByThree_ReturnBar()
        {
            //arrange
            FooBarQixDeterminer testee = new FooBarQixDeterminer();
            //act
            string actual = testee.Determine(5);
            //assert
            Assert.Equal("Bar", actual);
        }
        [Fact]
        public void Determine_DivideByThree_ReturnQix()
        {
            //arrange
            FooBarQixDeterminer testee = new FooBarQixDeterminer();
            //act
            string actual = testee.Determine(7);
            //assert
            Assert.Equal("Qix", actual);
        }
        [Theory]

        [InlineData(15, "FooBar")]
        [InlineData(21, "FooQix")]
        [InlineData(105, "FooBarQix")]
        public void Determine_DivideByThree_ReturnWordCombination(int number, string expected)
        {
            //arrange
            FooBarQixDeterminer testee = new FooBarQixDeterminer();
            //act
            string actual = testee.Determine(number);
            //assert
            Assert.Equal(expected, actual);
        }
        [Theory]

        [InlineData(1)]
        [InlineData(2)]
        [InlineData(32)]
        public void Determine_DivideByThree_ReturnNumber(int number)
        {
            //arrange
            FooBarQixDeterminer testee = new FooBarQixDeterminer();
            //act
            string actual = testee.Determine(number);
            //assert
            Assert.Equal(number.ToString(), actual);
        }

    }
}