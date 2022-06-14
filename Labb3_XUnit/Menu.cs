using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3_XUnit
{
    public class Menu
    {
        public static void MenuSelection()
        {
            List<double> numbers = new List<double>();
            List<string> calculations = new List<string>();
            string calcType;
            double num1 = 0;
            double num2 = 0;

            bool run = true;
            while (run)
            {
                Console.WriteLine("  \tCALCULATOR\n\n" +
                "  [1] Addition\n" +
                "  [2] Subtraction\n" +
                "  [3] Divison\n" +
                "  [4] Multiplication\n" +
                "  [5] Previous calculations\n");
                Console.Write("  Select: ");
                int select = 0;
                try
                {
                    select = Int32.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("  Please enter a number.");
                }

                if (select != 5)
                {
                    // User input
                    Console.Write("  Please enter first number: ");
                    num1 = Calculator.UserInput(Console.ReadLine());

                    Console.Write("  Please enter second number: ");
                    num2 = Calculator.UserInput(Console.ReadLine());
                }

                switch (select)
                {
                    case 1: // Addition
                        Console.Clear();
                        Console.WriteLine("  + ADDITION +\n");
                        calcType = "+";

                        calculations.Add(Calculator.PrintResult(num1, num2, Calculator.Addition(num1, num2), calcType));
                        break;
                    case 2: // Subtraction
                        Console.Clear();
                        Console.WriteLine("  - SUBTRACTION -\n");
                        calcType = "-";

                        calculations.Add(Calculator.PrintResult(num1, num2, Calculator.Subtraction(num1, num2), calcType));
                        break;
                    case 3: // Division
                        Console.Clear();
                        Console.WriteLine("  / Division /\n");
                        calcType = "/";

                        calculations.Add(Calculator.PrintResult(num1, num2, Calculator.Division(num1, num2), calcType));
                        break;
                    case 4:  // Multiplication
                        Console.Clear();
                        Console.WriteLine("  * Multiplication *\n");
                        calcType = "*";

                        calculations.Add(Calculator.PrintResult(num1, num2, Calculator.Multiplication(num1, num2), calcType));
                        break;

                    case 5: // Print all calculations
                        Console.Clear();
                        Console.WriteLine("  PREVIOUS CALCULATIONS");

                        Calculator.PrintAllCalculations(calculations);
                        break;
                    default:
                        break;
                }

                Console.WriteLine("\n\n  Press [Enter] to return to menu");
                Console.ReadKey();
                Console.Clear();
            }
            
        }
    }
}
