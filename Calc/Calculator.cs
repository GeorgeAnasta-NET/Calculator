using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator.Calc
{
    public class Calculator
    {
        public static double Addition(double firstNum, double secondNum)
        {
            double result = firstNum + secondNum;
            return result;
        }
        public static double Substaction(double firstNum, double secondNum)
        {
            double result = firstNum - secondNum;
            return result;
        }
        public static double Multiplication(double firstNum, double secondNum)
        {
            double result = firstNum * secondNum;
            return result;
        }
        public static double Division(double firstNum, double secondNum)
        {
             double result = firstNum / secondNum;
             return result;
        }
    }
}