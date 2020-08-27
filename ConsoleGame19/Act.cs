using System;
using System.Text;

namespace ConsoleGame19
{

    /// <summary>
    /// Класс для Выбора и текста выбора
    /// </summary>
    class Act
    {
        //Конструктор
        public Act()
        {
            Console.OutputEncoding = Encoding.UTF8;
        }

        public void TextСhoice(string one)
        {
            Console.WriteLine("\nСделайте выбор:");
            Console.WriteLine("1: " + one);
        }
        public void TextСhoice(string one, string two)
        {
            Console.WriteLine("\nСделайте выбор:");
            Console.WriteLine("1: " + one);
            Console.WriteLine("2: " + two);
        }
        public void TextСhoice(string one, string two, string three)
        {
            Console.WriteLine("\nСделайте выбор:");
            Console.WriteLine("1: " + one);
            Console.WriteLine("2: " + two);
            Console.WriteLine("3: " + three);
        }
        public void TextСhoice(string one, string two, string three, string four)
        {
            Console.WriteLine("\nСделайте выбор:");
            Console.WriteLine("1: " + one);
            Console.WriteLine("2: " + two);
            Console.WriteLine("3: " + three);
            Console.WriteLine("4: " + four);
        }
        /// <summary>
        /// a - здесь выводится основной текст, b1 - первый выбор и b2 второй выбор
        /// </summary>
        public void ForTextOut(string a, string b1, string b2)
        {
            ActTextPresents.TextPresents(a);
            TextСhoice(b1, b2);
        }
        /// <summary>
        /// a - здесь выводится основной текст, b1 - первый выбор и b2 второй выбор, b3 - третий выбор
        /// <summary>
        public void ForTextOut(string a, string b1, string b2, string b3)
        {
            ActTextPresents.TextPresents(a);
            TextСhoice(b1, b2, b3);
        }

        /// <summary>
        /// Ввод данных
        /// </summary>
        public int TextInput(int actChoice)
        {
            bool tryParse = true;
            while (tryParse == true)
            {
                if (actChoice > 3)
                {
                    try
                    {
                        actChoice = Convert.ToInt32(Console.ReadLine());
                        if (actChoice > 4)
                        {
                            Console.WriteLine("Введите корретное число (2)");
                        }
                    }
                    catch (Exception) { Console.WriteLine("Введите корректное число"); }
                }
                else { tryParse = false; }
            }
            return actChoice;
        }
    }
}