using Refactoring.Animals;
using Xunit;

namespace Refactoring.Tests;

public class ZooTest
{
    [Fact]
    public void makeNoise_Dog_textWithNameAndSaysWoof()
    {
        //arrange
        //act
       string result = Zoo.MakeNoise(new Dog("Fiddo"));
        //assert
       Assert.Equal("Fiddo says 'woof'", result);
    }
    [Fact]
    public void makeNoise_Cow_textWithNameAndSaysWoof()
    {
        //arrange
        //act
        string result = Zoo.MakeNoise(new Cow("Einstein"));
        //assert
        Assert.Equal("Einstein says 'mooh'", result);
    }
    [Fact]
    public void makeNoise_Horse_textWithNameAndSaysWoof()
    {
        //arrange
        //act
        string result = Zoo.MakeNoise(new Horse("GescheitertZ"));
        //assert
        Assert.Equal("GescheitertZ says 'neigh'", result);
    }

    
}