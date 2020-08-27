using System;
using System.Threading;

namespace ConsoleGame19
{
    /// <summary>
    /// Класс для вывода текста
    /// </summary>
    static class ActTextPresents // Не используется как задуманно(чисто вывод текста)
    {
        public static void TextPresents(string text) // Используется
        {
            for (int i = 0; i < text.Length - 1; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(0);
            }

            Console.WriteLine("\nНажмите Enter что бы продолжить...");
            Console.ReadKey();
        }

        public static void TextPresents(string text, int timeSpeed) // Не используется
        {
            for (int i = 0; i < text.Length - 1; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(timeSpeed);
            }

            Console.WriteLine("\nНажмите Enter что бы продолжить...");
            Console.ReadKey();
        }
     
    }
}
