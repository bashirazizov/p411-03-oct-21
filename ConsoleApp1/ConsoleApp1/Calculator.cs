using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //static class can't derive or be inherited
    static class Calculator
    {
        public static int Sum(params int[] nums)
        {
            int result = 0;
            foreach (int item in nums)
            {
                result += item;
            }
            return result;
        }

        public static int Multiply(params int[] nums)
        {
            int result = 1;
            foreach (int item in nums)
            {
                result *= item;
            }
            return result;
        }

        public static int Substract(int num1, int num2)
        {
            if (num1>num2)
            {
                return num1 - num2;
            }
            else
            {
                return num2 - num1;
            }

        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
