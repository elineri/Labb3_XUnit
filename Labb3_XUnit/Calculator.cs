using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3_XUnit
{
    public class Calculator
    {
        public static double UserInput(string num)
        {
            return Int32.Parse(num);
        }

        public static double Addition(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Division(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentNullException(nameof(num2));
            }
            return num1 / num2;
        }

        public static double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public static string PrintResult(double num1, double num2, double result, string calcType)
        {
            Console.Write($"  {num1} {calcType} {num2} = {result}");
            string calculation = num1.ToString() + calcType + num2.ToString() + result.ToString(); 
            return calculation;
        }

        public static void PrintAllCalculations(List<string> calculations)
        {
            for (int i = 0; i < calculations.Count; i+=4)
            {
                Console.WriteLine($"  {calculations[i]} {calculations[i+1]} {calculations[i+2]} = {calculations[i+3]}");
            }
        }
    }
}
