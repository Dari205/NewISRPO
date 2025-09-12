using System;
using System.Drawing;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четыре целых числа:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.SetCursorPosition((Console.WindowWidth - 1) / 2, Console.WindowHeight / 2 - 1); 

            if (IsThreeDigitNumber(a))
            {
                PrintNumberWithColor(a);
            }
            if (IsThreeDigitNumber(b))
            {
                Console.SetCursorPosition((Console.WindowWidth - 1) / 2, Console.WindowHeight / 2); 
                PrintNumberWithColor(b);
            }
            if (IsThreeDigitNumber(c))
            {
                Console.SetCursorPosition((Console.WindowWidth - 1) / 2, Console.WindowHeight / 2 + 1); 
                PrintNumberWithColor(c);
            }
            if (IsThreeDigitNumber(d))
            {
                Console.SetCursorPosition((Console.WindowWidth - 1) / 2, Console.WindowHeight / 2 + 2); 
                PrintNumberWithColor(d);
            }

            Console.ResetColor(); 
            Console.ReadKey(); 
        }

        static bool IsThreeDigitNumber(int number)
        {
            return number >= 100 && number <= 999;
        }

        static void PrintNumberWithColor(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (number % 5 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (number % 3 == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.Write($"{number} ");
        }
    }
}


