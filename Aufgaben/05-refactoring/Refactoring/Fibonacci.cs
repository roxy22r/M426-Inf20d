namespace Refactoring;

public class Fibonacci
{
    public static int Fib(int number)
    {
        int previous = 1;
        int result = 0;
        if (number < 0) {
            throw new ArgumentException("Fibonacci undefined for negative numbers");
        }
        for (int i = 0; i < number; i++) {
           int temp = result;
           result = previous;
           previous = temp + previous;
        }
     return result;
    }
}