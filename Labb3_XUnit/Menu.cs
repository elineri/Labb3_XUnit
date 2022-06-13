using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3_XUnit
{
    public class Menu
    {
        public static void MenuSelection()
        {
            bool run = true;
            List<int> numbers = new List<int>();

            while (run)
            {
                Console.WriteLine("  \tCALCULATOR\n\n" +
                "  1. Addition\n" +
                "  2. Subtraction\n" +
                "  3. Divison\n" +
                "  4. Multiplication\n" +
                "  5. Previous calculations\n");
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

                switch (select)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("  + ADDITION +\n");
                        numbers = Calculator.GetInput();
                        Calculator.PrintResult(Calculator.Addition(numbers[0], numbers[1]));
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("  - SUBTRACTION -\n");
                        numbers = Calculator.GetInput();
                        Calculator.PrintResult(Calculator.Subtraction(numbers[0], numbers[1]));
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("  / Division /\n");
                        numbers = Calculator.GetInput();
                        Calculator.PrintResult(Calculator.Division(numbers[0], numbers[1]));
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("  * Multiplication *\n");
                        numbers = Calculator.GetInput();
                        Calculator.PrintResult(Calculator.Multiplication(numbers[0], numbers[1]));
                        break;
                    default:
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
            
        }
    }
}
