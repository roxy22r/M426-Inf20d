using System;
using Xunit;
namespace Refactoring.Tests;

public class CurrencyConverterTest
{
 
    [Fact]
    public void convertTo_oneUsdInChf_onePointZeroNine()
    {
        // Arrange
        CurrencyConverter testee= new CurrencyConverter("USD");
        // Act
        double result = testee.ConvertToChf(1);

        // Assert
        Assert.Equal(1.09, result);
    }

    [Fact]
    public void convertTo_fiveEurInChf_fourPointEight()
    {
        // Arrange
        CurrencyConverter testee = new CurrencyConverter("EUR");
        // Act
        double result = testee.ConvertToChf(5);

        // Assert
        Assert.Equal(4.8, result);
    }
    [Fact]
    public void convertTo_elevenGbPInChf_ninePointZeroTwo()
    {
        // Arrange
        CurrencyConverter testee = new CurrencyConverter("GBP");
        // Act
        double result = testee.ConvertToChf(11);

        // Assert
        Assert.Equal(9.02, result);
    }

    [Fact]
    public void convertTo_TwoRubPInChf_ninePointZeroTwo()
    {
        // Arrange
        CurrencyConverter testee = new CurrencyConverter("RUB");
        // Act
        double result = testee.ConvertToChf(2);

        // Assert
        Assert.Equal(159.56, result);
    }
    [Fact]
    public void convertTo_nonExistingCurrencyToChf_thorwExeption()
    {
        // Arrange
        CurrencyConverter testee = new CurrencyConverter("lolCoin");
        // Act
        // Assert
        Assert.Throws<ArgumentException>(() => testee.ConvertToChf(1));
    }


}