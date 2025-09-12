using System;

public class Example
{
    public static void Main(string[] args)
    {
        // Ввод размера массива
        Console.Write("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine());

        // Ввод элементов массива
        int[] array = new int[10];
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(-1000, 1000); // Генерация случайного числа в диапазоне (-1000; 1000)
            Console.Write(array[i] + " ");
        }
        // Поиск максимальной последовательности положительных элементов
        int maxPos = 0;
        int currentPos = 0;
        int startI = 0;
        int endI = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                currentPos++;
                if (currentPos > maxPos)
                {
                    maxPos = currentPos; // Текущее кол-во пол. элементов становится максимальным 
                    startI = i - maxPos + 1;
                    endI = i;
                }
            }
            else
            {
                currentPos = 0;
            }
        }

        // Вывод массива с раскраской максимальной последовательности
        Console.WriteLine("\nВведенный массив:");
        for (int i = 0; i < array.Length; i++)
        {
            if (i >= startI && i <= endI)
            {
                Console.ForegroundColor = ConsoleColor.Cyan; // Установка бирюзового цвета
                Console.Write(array[i] + " ");
                Console.ResetColor(); // Сброс цвета
            }
            else
            {
                Console.Write(array[i] + " ");
            }
        }

        Console.WriteLine("\nМаксимальное количество последовательно расположенных положительных элементов: {0}", maxPos);
    }
}
