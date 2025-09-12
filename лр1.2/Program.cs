using System;

namespace WordGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заданный слог
            string syllable = "ло";

            int correctAnswers = 0;
            int attempts = 0;

            // Ввод слов до тех пор, пока не будет введена пустая строка
            while (true)
            {
                Console.Write("Введите слово, содержащее слог \"{0}\" (или пустую строку для завершения): ", syllable);
                string inputWord = Console.ReadLine();

                // Проверка на пустую строку
                if (inputWord == "")
                {
                    break;
                }

                attempts++;

                // Проверка на наличие слога в слове
                if (inputWord.ToLower().Contains(syllable))
                {
                    Console.WriteLine("Верно!");
                    correctAnswers++;
                }
                else
                {
                    Console.WriteLine("Неверно! Слово не содержит слог \"{0}\".", syllable);
                }
            }

            // Подсчет баллов
            int score = (int)Math.Round((double)correctAnswers / attempts * 100);

            // Вывод результатов
            Console.WriteLine("\nРезультат:");
            Console.WriteLine("Правильных ответов: {0}", correctAnswers);
            Console.WriteLine("Попыток: {0}", attempts);
            Console.WriteLine("Ваш балл: {0} из 100", score);

            Console.ReadKey();
        }
    }
}


