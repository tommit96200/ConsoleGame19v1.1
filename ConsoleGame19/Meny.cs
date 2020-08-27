using System;
using System.IO;
using System.Text;

namespace ConsoleGame19
{
    class Meny
    {
        Act act = new Act(); // Создаем объект для метода TextInput, который проверяет ввод на верность
        int choice; // Переменная для выбора в методах OutStart и ChoicePers

        //Реализация Старта и Выхода
        public int OutStart()
        {
            Console.WriteLine(" Старт(1) \n Выход(2)");            
            choice = Convert.ToInt32(Console.ReadLine());
            act.TextInput(choice);
            return choice;
        }

        //Реализация Выбора персонажей
        public int ChoicePers()
        {
            Console.WriteLine("Выберите персонажа: \n 1. Иван \n 2. Вадим");
            int choice = Convert.ToInt32(Console.ReadLine());
            act.TextInput(choice);
            return choice;
        }

        public void StrengConsole()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Title = "Приключения Ивана в армии";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetWindowSize(100, 25);
            Console.BufferHeight = 500;
            Console.BufferWidth = 100;
        }

        //Реализация персонажа Иван
        public void TurnIvan()
        {
            StreamReader a = new StreamReader(@"Text\0.txt");
            ActIvan act = new ActIvan();
            Act acts = new Act();
            int actChoice1 = 6, actChoice2 = 6, actChoice3 = 6, actChoice4 = 6;

            // НАЧАЛО
            ActTextPresents.TextPresents(a.ReadToEnd());
            
            //ПЕРВЫЙ ВЫБОР
            acts.TextСhoice("-Меня Ваня звать, я сюда не пирожки есть пришел, а чтоб служить!", "Ответить взаимностью", "Уебать с ноги одного из старослужащих");
            
            // Первый АКТ

            actChoice1 = acts.TextInput(actChoice1);
            act.TextOut(actChoice1);

            // Второй АКТ
            actChoice2 = acts.TextInput(actChoice2);
            act.TextOut(actChoice1, actChoice2);

            // Третий АКТ
            actChoice3 = acts.TextInput(actChoice3);
            act.TextOut(actChoice1, actChoice2, actChoice3);

            // Четвертый АКТ
            actChoice4 = acts.TextInput(actChoice4);
            act.TextOut(actChoice1, actChoice2, actChoice3, actChoice4);
        }

        //Реализация персонажа Вадим
        public void TurnVadim()
        {

        }

    }
}
