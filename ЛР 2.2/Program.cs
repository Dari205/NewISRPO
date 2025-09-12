using System;
using System.Collections.Generic;

namespace FindMinOddColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк двумерного массива:");
            int r = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов двумерного массива:");
            int c = int.Parse(Console.ReadLine());

            int[,] array = new int[r, c];

            Random random = new Random();
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    array[i, j] = random.Next(0, 100); // Генерация случайного числа в диапазоне (0; 100)
                }
            }

            // Нахождение столбца с наименьшим количеством нечетных элементов
            List<int> minColumns = FindMinColumns(array); //создание переменной типа список с результатом функции 

            // Вывод массива с раскраской столбцов
            Console.WriteLine("Массив с раскраской столбцов:");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (minColumns.Contains(j))
                    {
                        Console.ForegroundColor = ConsoleColor.Green; // Зеленый цвет
                    }
                    Console.Write($"{array[i, j]} ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }

        // Функция поиска столбцов с наименьшим количеством нечетных элементов
        static List<int> FindMinColumns(int[,] array)
        {
            int r = array.GetLength(0); //количество строк
            int c = array.GetLength(1); //количество столбцов

            // Храним количество нечетных элементов в каждом столбце
            int[] oddCount = new int[c];

            // Подсчитывание количества нечетных элементов в каждом столбце
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (array[i, j] % 2 != 0)
                    {
                        oddCount[j]++; 
                    }
                }
            }

            // Нахождение минимального количества нечетных элементов
            int minOdd = int.MaxValue; // Присваивание максимального значения переменной
            for (int i = 0; i < c; i++)
            {
                if (oddCount[i] < minOdd) // Сравнение количества нечетных элементов с минимальным
                {
                    minOdd = oddCount[i]; // Обновление значения переменной 
                }
            }

            // Спиcок столбцов с минимальным количеством нечетных элементов
            List<int> minColumns = new List<int>(); //Создание пустого списка
            for (int i = 0; i < c; i++)
            {
                if (oddCount[i] == minOdd)
                {
                    minColumns.Add(i); // Добавление индекса столбца в список
                }
            }
            return minColumns;
        }
    }
}