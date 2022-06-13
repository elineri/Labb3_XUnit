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
                Console.WriteLine("  \tCALCULATOR" +
                "  1. Addition\n" +
                "  2. Subtraction\n" +
                "  3. Divison\n" +
                "  4. Multiplication\n");
                Console.Write("  Choose option: ");
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
                        numbers = Calculator.GetInput();
                        Calculator.Addition(numbers[0], numbers[1]);
                        break;
                    case 2:
                        Console.Clear();
                        numbers = Calculator.GetInput();
                        Calculator.Subtraction(numbers[0], numbers[1]);
                        break;
                    case 3:
                        Console.Clear();
                        numbers = Calculator.GetInput();
                        Calculator.Division(numbers[0], numbers[1]);
                        break;
                    case 4:
                        Console.Clear();
                        numbers = Calculator.GetInput();
                        Calculator.Multiplication(numbers[0], numbers[1]);
                        break;
                    default:
                        break;
                }

                Console.ReadKey();
            }
            
        }
    }
}
