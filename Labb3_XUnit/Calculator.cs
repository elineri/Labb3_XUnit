using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3_XUnit
{
    public class Calculator
    {
        public static List<double> GetInput()
        {
            List<double> numbers = new List<double>();

            Console.Write("  First number: ");
            int num1 = Int32.Parse(Console.ReadLine());
            numbers.Add(num1);

            Console.Write("  Second number: ");
            int num2 = Int32.Parse(Console.ReadLine());
            numbers.Add(num2);

            return numbers;
        }

        public static double Addition(double num1, double num2)
        {
            Console.Write($"\n  {num1} + {num2}");
            return num1 + num2;
        }

        public static double Subtraction(double num1, double num2)
        {
            Console.Write($"\n  {num1} - {num2}");
            return num1 - num2;
        }

        public static double Division(double num1, double num2)
        {
            Console.Write($"\n  {num1} / {num2}");
            return num1 / num2;
        }

        public static double Multiplication(double num1, double num2)
        {
            Console.Write($"\n  {num1} * {num2}");
            return num1 * num2;
        }

        public static double PrintResult(double result)
        {
            Console.Write($" = {result}");
            return result;
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
