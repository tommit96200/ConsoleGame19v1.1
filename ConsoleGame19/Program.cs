using System;
using System.Text;

namespace ConsoleGame19
{
    class Program
    {
        static void Main()
        {
            Meny meny = new Meny();            

            meny.StrengConsole();

            int istart, iPers; // Переменные для проверки старта и выбора персонажа

            bool end = false;
            while (end == false)
            {

                // Старт и Выход
                istart = meny.OutStart();
                switch (istart)  //Реализация Старта и Выхода.
                {
                    case 1: break;
                    case 2: end = true; break;
                }

                if (end == false)
                {
                    //Выбор персонажа
                    iPers = meny.ChoicePers();
                    switch (iPers)
                    {
                        case 1: meny.TurnIvan(); end = true; break;
                        case 2: meny.TurnVadim(); end = true; break;

                    }
                }
            }
            Environment.Exit(0);
            
        }
    }
}
