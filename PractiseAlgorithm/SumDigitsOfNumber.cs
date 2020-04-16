using System;
using System.Collections.Generic;
using System.Text;

namespace PractiseAlgorithms
{
    public static class SumDigitsOfNumber
    {
        public static int SumDigit(int number)
        {
            if (number != 0)
            {
                return (number % 10 + SumDigit(number / 10));
            }
            else
            {
                return 0;
            }
        }
    }
}
