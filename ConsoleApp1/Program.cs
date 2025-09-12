using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Ввод размеров массива
        Console.WriteLine("Введите количество строк двумерного массива:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов двумерного массива:");
        int columns = int.Parse(Console.ReadLine());

        // Создание массива
        int[,] array = new int[rows, columns];

        // Генерируем случайные числа и заполняем массив
        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(0, 100); // Генерация случайного числа в диапазоне (0; 100)
            }
        }

        // Находим столбцы с наименьшим количеством нечетных элементов
        List<int> minOddColumns = FindMinOddColumns(array);

        // Вывод результата
        Console.WriteLine("Столбцы с наименьшим количеством нечетных элементов:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
        foreach (int column in minOddColumns)
        {
            Console.Write($"Столбец {column+1} ");
            Console.WriteLine();
        }
    }

    // Функция поиска столбцов с наименьшим количеством нечетных элементов
    static List<int> FindMinOddColumns(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        // Храним количество нечетных элементов в каждом столбце
        int[] oddCount = new int[columns];

        // Подсчитываем количество нечетных элементов в каждом столбце
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (array[i, j] % 2 != 0) // Проверяем нечетность элемента
                {
                    oddCount[j]++; // Увеличиваем счетчик для столбца j
                }
            }
        }

        // Находим минимальное количество нечетных элементов
        int minOdd = int.MaxValue; // Инициализируем минимальное значение как максимально возможное
        for (int i = 0; i < columns; i++)
        {
            if (oddCount[i] < minOdd)
            {
                minOdd = oddCount[i];
            }
        }

        // Собираем список столбцов с минимальным количеством нечетных элементов
        List<int> minOddColumns = new List<int>();
        for (int i = 0; i < columns; i++)
        {
            if (oddCount[i] == minOdd)
            {
                minOddColumns.Add(i);
            }
        }

        return minOddColumns;
    }
}
