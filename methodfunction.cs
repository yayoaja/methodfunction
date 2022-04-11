using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
        int min, max;
        public int FindMinimum(int number1, int number2)
        {
            return min = number2; 
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            return min = number2;   
        }

        public int FindMaximum(int number1, int number2)
        {
            return max = number1;
        }

        public int FindMaximum(int number1, int number2, int number3)
        {
            return max = number3;
        }
    }
}