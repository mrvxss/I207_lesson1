using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    public class Math
    {
        public static double Sum(double[] numbers)
        {
            var result = 0.0; ;
            foreach (var number in numbers)
            {
                result += number;
            }
            return result;
        }
        public double Minus(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Sum(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Multply(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Div( double num1, double num2)
        {
            return (num1 / num2);
        }
        public double Exdiv(double num1, double num2)
        {
            return num1 % num2;
        }

        public double percent(double Total, float precnt)
        {
            return Total * precnt / 100;
        }
        public double depercent(double Total, double value)
        {
            return Total / value * 100;
        }
        public double Count(double[] numbers)
        {
            return numbers.Length; 
        }
        public double Max(double[] numbers)
        {
            var result = 0.0;
            foreach (var number in numbers)
            {
                if (result < number)
                {
                    result=number;  
                }
            }
            return result;  
        }
        public double Min(double[] numbers)
        {
            var result = 0.0;  
            foreach (var number in numbers)
            {
                if (result > number) result = number;
            }
            return result;
        }
        public int factorial(int num1)
        {
            int result = 1;
            for (int i = 1; i <= num1; i++)
            {
                result *= i;
            }
            return result;
        }
        public double[] SortAscending(double[] numbers)
        {
            double[] result = (double[])numbers.Clone();
            Array.Sort(result);
            return result;
        }

        public double[] SortDescending(double[] numbers)
        {
            double[] result = (double[])numbers.Clone();
            Array.Sort(result);
            Array.Reverse(result);
            return result;
        }
    }
}
