using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int summandA, int summandB)
        {
            return summandA + summandB;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Multiply(int multiplicator, int multiplcand) {

            return multiplicator * multiplcand;
        }

        public int Division(int disvisorA,int divisorB){

            if (divisorB==0) {
                throw new ArgumentException(String.Format("{0} is not an even number", divisorB),  "num");
            }

            return disvisorA / divisorB;
        }
    }
}
