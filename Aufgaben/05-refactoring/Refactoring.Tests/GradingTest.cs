using System;
using Xunit;
namespace Refactoring.Tests;

public class GradingTest 
{
    [Fact]
    public void getLetterGrade_gradeOne_A()
    {
        // Arrange
        // Act
       char result = Grading.GetLetterGrade(1);

        // Assert
        Assert.Equal('A',result);
    }
    [Fact]
    public void getLetterGrade_gradeTwo_B()
    {
        // Arrange
        // Act
        char result = Grading.GetLetterGrade(2);

        // Assert
        Assert.Equal('B', result);
    }
    public void getLetterGrade_gradeThree_C()
    {
        // Arrange
        // Act
        char result = Grading.GetLetterGrade(3);

        // Assert
        Assert.Equal('C', result);
    }
    public void getLetterGrade_gradeFour_D()
    {
        // Arrange
        // Act
        char result = Grading.GetLetterGrade(4);

        // Assert
        Assert.Equal('D', result);
    }
    public void getLetterGrade_gradeFive_E()
    {
        // Arrange
        // Act
        char result = Grading.GetLetterGrade(5);

        // Assert
        Assert.Equal('E', result);
    }
    public void getLetterGrade_gradeSix_F()
    {
        // Arrange
        // Act
        char result = Grading.GetLetterGrade(6);
        // Assert
        Assert.Equal('F', result);
    }

    public void getLetterGrade_gradeHigherThenSix_thorwArgumentException()
    {
        // Arrange
        // Act
        // Assert
        Assert.Throws<ArgumentException>(() => Grading.GetLetterGrade(7));
    }
    public void getLetterGrade_gradeLowerThanOne_thorwArgumentException()
    {
        // Arrange
        // Act
        // Assert
        Assert.Throws<ArgumentException>(() =>Grading.GetLetterGrade(0));
    }
}