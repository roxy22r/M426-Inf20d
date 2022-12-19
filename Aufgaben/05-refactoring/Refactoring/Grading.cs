namespace Refactoring;

public class Grading
{
    public static char GetLetterGrade(int grade)
    {
        return grade >= 1 && grade <= 6 ?//
               (char)(grade + 64) : throw new ArgumentException("unknown grade " + grade);

     
    }
}