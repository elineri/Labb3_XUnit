using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3_XUnit
{
    public class Calculator
    {
        public static List<int> GetInput()
        {
            List<int> numbers = new List<int>();

            Console.Write("  First number: ");
            int num1 = Int32.Parse(Console.ReadLine());
            numbers.Add(num1);

            Console.Write("  Second number: ");
            int num2 = Int32.Parse(Console.ReadLine());
            numbers.Add(num2);

            return numbers;
        }

        public static double Addition(int num1, int num2)
        {
            Console.Write($"\n  {num1} + {num2}");
            return num1 + num2;
        }

        public static double Subtraction(int num1, int num2)
        {
            Console.Write($"\n  {num1} - {num2}");
            return num1 - num2;
        }

        public static double Division(int num1, int num2)
        {
            Console.Write($"\n  {num1} / {num2}");
            return num1 / num2;
        }

        public static double Multiplication(int num1, int num2)
        {
            Console.Write($"\n  {num1} * {num2}");
            return num1 * num2;
        }

        public static void PrintResult(double result)
        {
            Console.Write($" = {result}");
        }
    }
}
