using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Average
    {
        public double Mean(List<int> numbers)
        {
            int sum = 0;
            double mean = 0.0;

            if (numbers.Count > 0)
            {
                foreach (int number in numbers)
                {
                    sum += number;
                }
            }
            else {
                throw new ArgumentException(String.Format("{0} can't be Empty", numbers), "num");

            }

            mean = (double)sum / numbers.Count;
            return mean;
        }
    }

      
}
