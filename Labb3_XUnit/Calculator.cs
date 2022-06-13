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

            Console.WriteLine("Ange första tal: ");
            int num1 = Int32.Parse(Console.ReadLine());
            numbers.Add(num1);

            Console.WriteLine("Ange andra tal: ");
            int num2 = Int32.Parse(Console.ReadLine());
            numbers.Add(num2);

            return numbers;
        }

        public static void Addition(int num1, int num2)
        {
            double result = num1 + num2;
        }

        public static void Subtraction(int num1, int num2)
        {
            double result = num1 - num2;
        }

        public static void Division(int num1, int num2)
        {
            double result = num1 / num2;
        }

        public static void Multiplication(int num1, int num2)
        {
            double result = num1 * num2;
        }

        public void PrintCalculationResult(double result)
        {
            Console.WriteLine(result);
        }
    }
}
