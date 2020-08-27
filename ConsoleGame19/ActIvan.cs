using System.IO;
using System.Text;

namespace ConsoleGame19
{
    class ActIvan
    {
        //Первый акт
        StreamReader a = new StreamReader(@"Text\1Act\a.txt", Encoding.UTF8);
        StreamReader b = new StreamReader(@"Text\1Act\b.txt", Encoding.UTF8);
        StreamReader c = new StreamReader(@"Text\1Act\c.txt", Encoding.UTF8);

        //Второй акт 
        StreamReader a_1 = new StreamReader(@"Text\2Act\a_1.txt", Encoding.UTF8);
        StreamReader a_2 = new StreamReader(@"Text\2Act\a_2.txt", Encoding.UTF8);

        StreamReader b_1 = new StreamReader(@"Text\2Act\b_1.txt", Encoding.UTF8);
        StreamReader b_2 = new StreamReader(@"Text\2Act\b_2.txt", Encoding.UTF8);

        StreamReader c_1 = new StreamReader(@"Text\2Act\c_1.txt", Encoding.UTF8);
        StreamReader c_2 = new StreamReader(@"Text\2Act\c_2.txt", Encoding.UTF8);

        //Третий акт
        StreamReader a_1_1 = new StreamReader(@"Text\3Act\a_1_1.txt", Encoding.UTF8);
        StreamReader a_1_2 = new StreamReader(@"Text\3Act\a_1_2.txt", Encoding.UTF8);

        StreamReader a_2_1 = new StreamReader(@"Text\3Act\a_2_1.txt", Encoding.UTF8);
        StreamReader a_2_2 = new StreamReader(@"Text\3Act\a_2_2.txt", Encoding.UTF8);

        StreamReader b_1_1 = new StreamReader(@"Text\3Act\b_1_1.txt", Encoding.UTF8);
        StreamReader b_1_2 = new StreamReader(@"Text\3Act\b_1_2.txt", Encoding.UTF8);

        StreamReader b_2_1 = new StreamReader(@"Text\3Act\b_2_1.txt", Encoding.UTF8);
        StreamReader b_2_2 = new StreamReader(@"Text\3Act\b_2_2.txt", Encoding.UTF8);

        StreamReader c_1_1 = new StreamReader(@"Text\3Act\c_1_1.txt", Encoding.UTF8);
        StreamReader c_1_2 = new StreamReader(@"Text\3Act\c_1_2.txt", Encoding.UTF8);

        StreamReader c_2_1 = new StreamReader(@"Text\3Act\c_2_1.txt", Encoding.UTF8);
        StreamReader c_2_2 = new StreamReader(@"Text\3Act\c_2_2.txt", Encoding.UTF8);

        //Четвертый акт
        StreamReader a_1_1_1 = new StreamReader(@"Text\4Act\a_1_1_1.txt", Encoding.UTF8);
        StreamReader a_1_1_2 = new StreamReader(@"Text\4Act\a_1_1_2.txt", Encoding.UTF8);

        StreamReader a_1_2_1 = new StreamReader(@"Text\4Act\a_1_2_1.txt", Encoding.UTF8);
        StreamReader a_1_2_2 = new StreamReader(@"Text\4Act\a_1_2_2.txt", Encoding.UTF8);

        StreamReader a_2_1_1 = new StreamReader(@"Text\4Act\a_2_1_1.txt", Encoding.UTF8);
        StreamReader a_2_1_2 = new StreamReader(@"Text\4Act\a_2_1_2.txt", Encoding.UTF8);

        StreamReader a_2_2_1 = new StreamReader(@"Text\4Act\a_2_2_1.txt", Encoding.UTF8);
        StreamReader a_2_2_2 = new StreamReader(@"Text\4Act\a_2_2_2.txt", Encoding.UTF8);


        StreamReader b_1_1_1 = new StreamReader(@"Text\4Act\b_1_1_1.txt", Encoding.UTF8);
        StreamReader b_1_1_2 = new StreamReader(@"Text\4Act\b_1_1_2.txt", Encoding.UTF8);

        StreamReader b_1_2_1 = new StreamReader(@"Text\4Act\b_1_2_1.txt", Encoding.UTF8);
        StreamReader b_1_2_2 = new StreamReader(@"Text\4Act\b_1_2_2.txt", Encoding.UTF8);

        StreamReader b_2_1_1 = new StreamReader(@"Text\4Act\b_2_1_1.txt", Encoding.UTF8);
        StreamReader b_2_1_2 = new StreamReader(@"Text\4Act\b_2_1_2.txt", Encoding.UTF8);

        StreamReader b_2_2_1 = new StreamReader(@"Text\4Act\b_2_2_1.txt", Encoding.UTF8);
        StreamReader b_2_2_2 = new StreamReader(@"Text\4Act\b_2_2_2.txt", Encoding.UTF8);


        StreamReader c_1_1_1 = new StreamReader(@"Text\4Act\c_1_1_1.txt", Encoding.UTF8);
        StreamReader c_1_1_2 = new StreamReader(@"Text\4Act\c_1_1_2.txt", Encoding.UTF8);

        StreamReader c_1_2_1 = new StreamReader(@"Text\4Act\c_1_2_1.txt", Encoding.UTF8);
        StreamReader c_1_2_2 = new StreamReader(@"Text\4Act\c_1_2_2.txt", Encoding.UTF8);

        StreamReader c_2_1_1 = new StreamReader(@"Text\4Act\c_2_1_1.txt", Encoding.UTF8);
        StreamReader c_2_1_2 = new StreamReader(@"Text\4Act\c_2_1_2.txt", Encoding.UTF8);

        StreamReader c_2_2_1 = new StreamReader(@"Text\4Act\c_2_2_1.txt", Encoding.UTF8);
        StreamReader c_2_2_2 = new StreamReader(@"Text\4Act\c_2_2_2.txt", Encoding.UTF8);

       
        Act acts = new Act();



        /// <summary>
        /// Первый Акт
        /// </summary>
        public void TextOut(int first)
        {           
            // Первая ветка A
            if (first == 1)
            {
                acts.ForTextOut(a.ReadToEnd(), "Взять кофе", "Отказаться");
            }
            // Вторая ветка B
            else if (first == 2)
            {
                acts.ForTextOut(b.ReadToEnd(), "В туалеты", "В штаб к Генералу");
            }
            // Третья ветка C
            else if (first == 3)
            {
                acts.ForTextOut(c.ReadToEnd(), "Ваня пойдет мстить", "забыть и служить дальше");
            }
        }

        /// <summary>
        /// Второй Акт
        /// </summary>
        public void TextOut(int first, int second)
        {
            // Первая ветка A
            if (first == 1)
            {
                if (second == 1)
                {   //История A_1
                    acts.ForTextOut(a_1.ReadToEnd(), "Импровизировать", "Пойти в канцелярию за кипяточком к Очаровательному командиру взвода");                   
                }
                else if (second == 2)
                {   //История A_2                    
                    acts.ForTextOut(a_2.ReadToEnd(), "Отправить дневального часок поспать", "Пусть стоит душара");                   
                }
                else if (second == 3)
                {   //История A_3
                    ActTextPresents.TextPresents("История A_3");
                } //Не используется
            }
            // Вторая ветка B
            else if (first == 2)
            {
                if (second == 1)
                {   //История B_1
                    acts.ForTextOut(b_1.ReadToEnd(), "Пойти и извиниться", "сбежать из части ");                    
                }
                else if (second == 2)
                {   //История B_2
                    acts.ForTextOut(b_2.ReadToEnd(), "Сказать что он покончит жизнь самоубийством ", "Что Полковник мудак");                    
                }
                else if (second == 3)
                {   //История B_3
                    ActTextPresents.TextPresents("История B_3");
                } //Не используется
            }
            // Третья ветка C
            else if (first == 3)
            {
                if (second == 1)
                {   //История С_1
                    acts.ForTextOut(c_1.ReadToEnd(), "Кивнуть ему что бы уходил", "Сразиться с обоими сразу");                    
                }
                else if (second == 2)
                {   //История С_2
                    acts.ForTextOut(c_2.ReadToEnd(), "Выбрать наземную группу", "Быть водителем танка");                    
                }
                else if (second == 3)
                {   //История С_3
                    ActTextPresents.TextPresents("История С_3");
                } //Не используется
            }
        }

        /// <summary>
        /// Третий Акт
        /// </summary>
        public void TextOut(int first, int second, int third)
        {
            // Первая ветка A
            if (first == 1)
            {
                if (second == 1)
                {
                    if (third == 1)
                    {
                        //История A_1_1
                        ActTextPresents.TextPresents(a_1_1.ReadToEnd());
                        // Тут конец истории
                    }
                    else if (third == 2)
                    {
                        //История A_1_2
                        ActTextPresents.TextPresents(a_1_2.ReadToEnd());
                        acts.TextСhoice("Согласиться", "Отказать");
                    }
                    else if (third == 3)
                    {
                        //История A_1_3
                        ActTextPresents.TextPresents("История A_1_3 ");
                    } //Не используется
                }
                else if (second == 2)
                {
                    if (third == 1)
                    {
                        //История A_2_1
                        ActTextPresents.TextPresents(a_2_1.ReadToEnd());
                        acts.TextСhoice("Нужно использовать момент", "Помочь Вике");
                    }
                    else if (third == 2)
                    {
                        //История A_2_2
                        ActTextPresents.TextPresents(a_2_2.ReadToEnd());
                        acts.TextСhoice("Пришел ночью как и было велено", "Послал того дневального вместо себя");
                    }
                    else if (third == 3)
                    {
                        //История A_2_3
                        ActTextPresents.TextPresents("История A_2_3 ");
                    } //Не используется
                }
                else if (second == 3)
                {
                    if (third == 1)
                    {
                        //История A_3_1
                        ActTextPresents.TextPresents("История A_3_1 ");
                        acts.TextСhoice("", "");
                    }
                    else if (third == 2)
                    {
                        //История A_3_2
                        ActTextPresents.TextPresents("История A_3_2 ");
                        acts.TextСhoice("", "");
                    }
                    else if (third == 3)
                    {
                        //История A_3_3
                        ActTextPresents.TextPresents("История A_3_3 ");
                    } //Не используется
                } //Не используется
            }
            //Вторая ветка B
            else if (first == 2)
            {
                if (second == 1)
                {
                    if (third == 1)
                    {
                        //История B_1_1
                        ActTextPresents.TextPresents(b_1_1.ReadToEnd());
                        acts.TextСhoice("Деликатно отказаться ", "Пойти и спиздить этот злоебучий бушлат");
                    }
                    else if (third == 2)
                    {
                        //История B_1_2
                        ActTextPresents.TextPresents(b_1_2.ReadToEnd());
                        acts.TextСhoice("Поехать на попутках домой", "Сесть на маршрутку и доехать до вокзала");
                    }
                    else if (third == 3)
                    {
                        //История B_1_3
                        ActTextPresents.TextPresents("История B_1_1_1 ");
                    } //Не используется
                }
                else if (second == 2)
                {
                    if (third == 1)
                    {
                        //История B_2_1
                        ActTextPresents.TextPresents(b_2_1.ReadToEnd());
                        // Тут конец
                    }
                    else if (third == 2)
                    {
                        //История B_2_2
                        ActTextPresents.TextPresents(b_2_2.ReadToEnd());
                        acts.TextСhoice("Отказался", "Согласился");
                    }
                    else if (third == 3)
                    {
                        //История B_2_3
                        ActTextPresents.TextPresents("История B_2_3 ");
                    } //Не используется
                }
                else if (second == 3)
                {
                    if (third == 1)
                    {
                        //История B_3_1
                        ActTextPresents.TextPresents("История B_3_1 ");
                    }
                    else if (third == 2)
                    {
                        //История B_3_2
                        ActTextPresents.TextPresents("История B_3_2 ");
                    }
                    else if (third == 3)
                    {
                        //История B_3_3
                        ActTextPresents.TextPresents("История B_3_3 ");
                    }
                } //Не используется
            }
            //Третья  ветка С
            else if (first == 3)
            {
                if (second == 1)
                {
                    if (third == 1)
                    {
                        //История С_1_1
                        ActTextPresents.TextPresents(c_1_1.ReadToEnd());
                        acts.TextСhoice("Отказать ему, деликатно", "Принять предложение Вадима");
                    }
                    else if (third == 2)
                    {
                        //История С_1_2
                        ActTextPresents.TextPresents(c_1_2.ReadToEnd());
                        // Тут конец
                    }
                    else if (third == 3)
                    {
                        //История С_1_3
                        ActTextPresents.TextPresents("История C_1_3 ");
                    } //Не используется
                }
                else if (second == 2)
                {
                    if (third == 1)
                    {
                        //История С_2_1
                        ActTextPresents.TextPresents(c_2_1.ReadToEnd());
                        acts.TextСhoice("Попытаться дотерпеть.........", "Снять штаны и сделать все здесь и сейчас, ведь природа не ждет.");
                    }
                    else if (third == 2)
                    {
                        //История С_2_2
                        ActTextPresents.TextPresents(c_2_2.ReadToEnd());
                        acts.TextСhoice("Продать почку", "Пойти под статью");
                    }
                    else if (third == 3)
                    {
                        //История С_2_3
                        ActTextPresents.TextPresents("История C_2_3 ");
                    } //Не используется
                }
                else if (second == 3)
                {
                    if (third == 1)
                    {
                        //История С_3_1
                        ActTextPresents.TextPresents("История C_3_1 ");
                    }
                    else if (third == 2)
                    {
                        //История С_3_2
                        ActTextPresents.TextPresents("История C_3_2 ");
                    }
                    else if (third == 3)
                    {
                        //История С_3_3
                        ActTextPresents.TextPresents("История C_3_3 ");
                    }
                } //Не используется
            }
        }

        /// <summary>
        /// Четвертый Акт
        /// </summary>
        public void TextOut(int first, int second, int third, int four)
        {
            // Первая ветка A
            if (first == 1)
            {
                if (second == 1)
                {
                    if (third == 1)
                    {
                        if (four == 1)
                        {
                            //История A_1_1_1
                            ActTextPresents.TextPresents(a_1_1_1.ReadToEnd());
                            // Тут конец
                        }
                        else if (four == 2)
                        {
                            //История A_1_1_2
                            ActTextPresents.TextPresents(a_1_1_2.ReadToEnd());
                            // Тут конец
                        }
                        else if (four == 3)
                        {
                            //История A_1_1_3
                            ActTextPresents.TextPresents("История A_1_1_3 ");
                        } //Не используется
                    }
                    else if (third == 2)
                    {
                        if (four == 1)
                        {
                            //История A_1_2_1
                            ActTextPresents.TextPresents(a_1_2_1.ReadToEnd());
                            //Тут конец
                        }
                        else if (four == 2)
                        {
                            //История A_1_2_2
                            ActTextPresents.TextPresents(a_1_2_2.ReadToEnd());
                            //Тут конец
                        }
                        else if (four == 3)
                        {
                            //История A_1_2_3
                            ActTextPresents.TextPresents("История 4.3b ");
                        } //Не используется
                    }
                    else if (third == 3)
                    {
                        if (four == 1)
                        {
                            //История 
                            ActTextPresents.TextPresents("История 4.1c ");
                        }
                        else if (four == 2)
                        {
                            //История  
                            ActTextPresents.TextPresents("История 4.2c ");
                        }
                        else if (four == 3)
                        {
                            //История  
                            ActTextPresents.TextPresents("История 4.3c ");
                        }
                    } //Не используется
                }
                else if (second == 2)
                {
                    if (third == 1)
                    {
                        if (four == 1)
                        {
                            //История A_2_1_1
                            ActTextPresents.TextPresents(a_2_1_1.ReadToEnd());
                            //Конец
                        }
                        else if (four == 2)
                        {
                            //История A_2_1_2
                            ActTextPresents.TextPresents(a_2_1_2.ReadToEnd());
                            //Конец
                        }
                        else if (four == 3)
                        {
                            //История A_2_1_3
                            ActTextPresents.TextPresents("История 4.3d ");
                        } //Не используется
                    }
                    else if (third == 2)
                    {
                        if (four == 1)
                        {
                            //История A_2_2_1
                            ActTextPresents.TextPresents(a_2_2_1.ReadToEnd());
                            //Конец
                        }
                        else if (four == 2)
                        {
                            //История A_2_2_2
                            ActTextPresents.TextPresents(a_2_2_2.ReadToEnd());
                            //Конец
                        }
                        else if (four == 3)
                        {
                            //История A_2_2_3
                            ActTextPresents.TextPresents("История 4.3d ");
                        } //Не используется
                    }
                    else if (third == 3)
                    {
                        if (four == 1)
                        {
                            //История A_1_1_6_1
                            ActTextPresents.TextPresents("История 4.1d ");
                        }
                        else if (four == 2)
                        {
                            //История A_1_1_6_2
                            ActTextPresents.TextPresents("История 4.2d ");
                        }
                        else if (four == 3)
                        {
                            //История A_1_1_6_3
                            ActTextPresents.TextPresents("История 4.3d ");
                        }
                    } //Не используется
                }
                else if (second == 3)
                {
                    if (third == 1)
                    {
                        if (four == 1)
                        {
                            //История A_1_1_7_1
                            ActTextPresents.TextPresents("История 4.1d ");
                        }
                        else if (four == 2)
                        {
                            //История A_1_1_7_2
                            ActTextPresents.TextPresents("История 4.2d ");
                        }
                        else if (four == 3)
                        {
                            //История A_1_1_7_3
                            ActTextPresents.TextPresents("История 4.3d ");
                        }
                    }
                    else if (third == 2)
                    {
                        if (four == 1)
                        {
                            //История A_1_1_8_1
                            ActTextPresents.TextPresents("История 4.1d ");
                        }
                        else if (four == 2)
                        {
                            //История A_1_1_8_2
                            ActTextPresents.TextPresents("История 4.2d ");
                        }
                        else if (four == 3)
                        {
                            //История A_1_1_8_3
                            ActTextPresents.TextPresents("История 4.3d ");
                        }
                    }
                    else if (third == 3)
                    {
                        if (four == 1)
                        {
                            //История A_1_1_9_1
                            ActTextPresents.TextPresents("История 4.1d ");
                        }
                        else if (four == 2)
                        {
                            //История A_1_1_9_2
                            ActTextPresents.TextPresents("История 4.2d ");
                        }
                        else if (four == 3)
                        {
                            //История A_1_1_9_3
                            ActTextPresents.TextPresents("История 4.3d ");
                        }
                    }
                } //Не используется
            }
            // Вторая ветка B
            else if (first == 2)
            {
                if (second == 1)
                {
                    if (third == 1)
                    {
                        if (four == 1)
                        {
                            //История B_1_1_1
                            ActTextPresents.TextPresents(b_1_1_1.ReadToEnd());
                        }
                        else if (four == 2)
                        {
                            //История B_1_1_2
                            ActTextPresents.TextPresents(b_1_1_2.ReadToEnd());
                        }
                        else if (four == 3)
                        {
                            //История B_1_1_3
                            ActTextPresents.TextPresents("История 4.3d ");
                        } //Не используется
                    }
                    else if (third == 2)
                    {
                        if (four == 1)
                        {
                            //История B_1_2_1
                            ActTextPresents.TextPresents(b_1_2_1.ReadToEnd());
                        }
                        else if (four == 2)
                        {
                            //История B_1_2_2
                            ActTextPresents.TextPresents(b_1_2_2.ReadToEnd());
                        }
                        else if (four == 3)
                        {
                            //История B_1_2_3
                            ActTextPresents.TextPresents("История 4.3d ");
                        } //Не используется
                    }
                    else if (third == 3)
                    {
                        if (four == 1)
                        {
                            //История B_1_1_3_1
                            ActTextPresents.TextPresents("История 4.1d ");
                        }
                        else if (four == 2)
                        {
                            //История B_1_1_3_2
                            ActTextPresents.TextPresents("История 4.2d ");
                        }
                        else if (four == 3)
                        {
                            //История B_1_1_3_3
                            ActTextPresents.TextPresents("История 4.3d ");
                        }
                    } //Не используется
                }
                else if (second == 2)
                {
                    if (third == 1)
                    {
                        if (four == 1)
                        {
                            //История B_2_1_1
                            ActTextPresents.TextPresents(b_2_1_1.ReadToEnd());
                        }
                        else if (four == 2)
                        {
                            //История B_2_1_2
                            ActTextPresents.TextPresents(b_2_1_2.ReadToEnd());
                        }
                        else if (four == 3)
                        {
                            //История B_2_1_3
                            ActTextPresents.TextPresents("История 4.3d ");
                        } //Не используется
                    }
                    else if (third == 2)
                    {
                        if (four == 1)
                        {
                            //История B_2_2_1
                            ActTextPresents.TextPresents(b_2_2_1.ReadToEnd());
                        }
                        else if (four == 2)
                        {
                            //История B_2_2_2
                            ActTextPresents.TextPresents(b_2_2_2.ReadToEnd());
                        }
                        else if (four == 3)
                        {
                            //История B_2_2_3
                            ActTextPresents.TextPresents("История 4.3d ");
                        } //Не используется
                    }
                    else if (third == 3)
                    {
                        if (four == 1)
                        {
                            //История
                            ActTextPresents.TextPresents("История 4.1d ");
                        }
                        else if (four == 2)
                        {
                            //История
                            ActTextPresents.TextPresents("История 4.2d ");
                        }
                        else if (four == 3)
                        {
                            //История
                            ActTextPresents.TextPresents("История 4.3d ");
                        }
                    } //Не используется
                }
                else if (second == 3)
                {
                    if (third == 1)
                    {
                        if (four == 1)
                        {
                            //История B_1_1_7_1
                            ActTextPresents.TextPresents("История 4.1d ");
                        }
                        else if (four == 2)
                        {
                            //История B_1_1_7_2
                            ActTextPresents.TextPresents("История 4.2d ");
                        }
                        else if (four == 3)
                        {
                            //История B_1_1_7_3
                            ActTextPresents.TextPresents("История 4.3d ");
                        }
                    }
                    else if (third == 2)
                    {
                        if (four == 1)
                        {
                            //История B_1_1_8_1
                            ActTextPresents.TextPresents("История 4.1d ");
                        }
                        else if (four == 2)
                        {
                            //История B_1_1_8_2
                            ActTextPresents.TextPresents("История 4.2d ");
                        }
                        else if (four == 3)
                        {
                            //История B_1_1_8_3
                            ActTextPresents.TextPresents("История 4.3d ");
                        }
                    }
                    else if (third == 3)
                    {
                        if (four == 1)
                        {
                            //История B_1_1_9_1
                            ActTextPresents.TextPresents("История 4.1d ");
                        }
                        else if (four == 2)
                        {
                            //История B_1_1_9_2
                            ActTextPresents.TextPresents("История 4.2d ");
                        }
                        else if (four == 3)
                        {
                            //История B_1_1_9_3
                            ActTextPresents.TextPresents("История 4.3d ");
                        }
                    }
                } //Не используется
            }
            // Третья  ветка C
            else if (first == 3)
            {
                if (second == 1)
                {
                    if (third == 1)
                    {
                        if (four == 1)
                        {
                            //История C_1_1_1
                            ActTextPresents.TextPresents(c_1_1_1.ReadToEnd());
                            //Конец
                        }
                        else if (four == 2)
                        {
                            //История C_1_1_2
                            ActTextPresents.TextPresents(c_1_1_2.ReadToEnd());
                            //Конец
                        }
                        else if (four == 3)
                        {
                            //История C_1_1_3
                            ActTextPresents.TextPresents("История C_1_1_3 ");
                        } //Не используется
                    }
                    else if (third == 2)
                    {
                        if (four == 1)
                        {
                            //История C_1_2_1
                            ActTextPresents.TextPresents(c_1_2_1.ReadToEnd());
                            //Конец
                        }
                        else if (four == 2)
                        {
                            //История C_1_2_2
                            ActTextPresents.TextPresents(c_1_2_2.ReadToEnd());
                            //Конец
                        }
                        else if (four == 3)
                        {
                            //История C_1_2_3
                            ActTextPresents.TextPresents("История 4.3d ");
                        } //Не используется
                    }
                    else if (third == 3)
                    {
                        if (four == 1)
                        {
                            //История C_1_1_3_1
                            ActTextPresents.TextPresents("История 4.1d ");
                        }
                        else if (four == 2)
                        {
                            //История C_1_1_3_2
                            ActTextPresents.TextPresents("История 4.2d ");
                        }
                        else if (four == 3)
                        {
                            //История C_1_1_3_3
                            ActTextPresents.TextPresents("История 4.3d ");
                        }
                    } //Не используется
                }
                else if (second == 2)
                {
                    if (third == 1)
                    {
                        if (four == 1)
                        {
                            //История С_2_1_1
                            ActTextPresents.TextPresents(c_2_1_1.ReadToEnd());
                            //Конец
                        }
                        else if (four == 2)
                        {
                            //История C_2_1_2
                            ActTextPresents.TextPresents(c_2_1_2.ReadToEnd());
                            //Конец
                        }
                        else if (four == 3)
                        {
                            //История C_2_1_2
                            ActTextPresents.TextPresents("История 4.3d ");
                        } //Не используется
                    }
                    else if (third == 2)
                    {
                        if (four == 1)
                        {
                            //История c_2_2_1
                            ActTextPresents.TextPresents(c_2_2_2.ReadToEnd());
                            //Конец
                        }
                        else if (four == 2)
                        {
                            //История c_2_2_2
                            ActTextPresents.TextPresents(c_2_2_2.ReadToEnd());
                            //Конец
                        }
                        else if (four == 3)
                        {
                            //История c_2_2_3
                            ActTextPresents.TextPresents("История 4.3d ");
                        } //Не используется
                    }
                    else if (third == 3)
                    {
                        if (four == 1)
                        {
                            //История C_1_1_6_1
                            ActTextPresents.TextPresents("История 4.1d ");
                        }
                        else if (four == 2)
                        {
                            //История C_1_1_6_2
                            ActTextPresents.TextPresents("История 4.2d ");
                        }
                        else if (four == 3)
                        {
                            //История C_1_1_6_3
                            ActTextPresents.TextPresents("История 4.3d ");
                        }
                    } //Не используется
                }
                else if (second == 3)
                {
                    if (third == 1)
                    {
                        if (four == 1)
                        {
                            //История C_1_1_7_1
                            ActTextPresents.TextPresents("История 4.1d ");
                        }
                        else if (four == 2)
                        {
                            //История C_1_1_7_2
                            ActTextPresents.TextPresents("История 4.2d ");
                        }
                        else if (four == 3)
                        {
                            //История C_1_1_7_3
                            ActTextPresents.TextPresents("История 4.3d ");
                        }
                    }
                    else if (third == 2)
                    {
                        if (four == 1)
                        {
                            //История C_1_1_8_1
                            ActTextPresents.TextPresents("История 4.1d ");
                        }
                        else if (four == 2)
                        {
                            //История C_1_1_8_2
                            ActTextPresents.TextPresents("История 4.2d ");
                        }
                        else if (four == 3)
                        {
                            //История C_1_1_8_3
                            ActTextPresents.TextPresents("История 4.3d ");
                        }
                    }
                    else if (third == 3)
                    {
                        if (four == 1)
                        {
                            //История C_1_1_9_1
                            ActTextPresents.TextPresents("История 4.1d ");
                        }
                        else if (four == 2)
                        {
                            //История C_1_1_9_2
                            ActTextPresents.TextPresents("История 4.2d ");
                        }
                        else if (four == 3)
                        {
                            //История C_1_1_9_3
                            ActTextPresents.TextPresents("История 4.3d ");
                        }
                    } // Не используется
                } //Не используется
            }
        }

        /// <summary>
        /// Пятый Акт
        /// </summary>
        public void TextOut(int first, int second, int third, int four, int five)
        {
            // Первая ветка A_1
            if (first == 1)
            {
                if (second == 1)
                {
                    if (third == 1)
                    {
                        if (four == 1)
                        {
                            if (five == 1)
                            {
                                //История A_1_1_1_1_1
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                //История A_1_1_1_1_2
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                //История A_1_1_1_1_3
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 2)
                        {
                            if (five == 1)
                            {
                                //История A_1_1_1_2_1
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                //История A_1_1_1_2_2
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                //История A_1_1_1_2_3
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 3)
                        {
                            if (five == 1)
                            {
                                //История A_1_1_1_4_1
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                //История A_1_1_1_4_2
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                //История A_1_1_1_4_3
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                    }
                    else if (third == 2)
                    {
                        if (four == 1)
                        {
                            if (five == 1)
                            {
                                //История A_1_1_1_2_1
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                //История A_1_1_1_2_2
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                //История A_1_1_1_2_3
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 2)
                        {
                            if (five == 1)
                            {
                                //История A_1_1_1_2_1
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                //История A_1_1_1_2_2
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                //История A_1_1_1_2_3
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 3)
                        {
                            if (five == 1)
                            {
                                //История A_1_1_1_2_1
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                //История A_1_1_1_2_2
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                //История A_1_1_1_2_3
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                    }
                    else if (third == 3)
                    {
                        if (four == 1)
                        {
                            if (five == 1)
                            {
                                //История A_1_1_1_2_1
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                //История A_1_1_1_2_2
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                //История A_1_1_1_2_3
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 2)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 3)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                    }
                }
                else if (second == 2)
                {
                    if (third == 1)
                    {
                        if (four == 1)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 2)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 3)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                    }
                    else if (third == 2)
                    {
                        if (four == 1)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 2)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 3)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                    }
                    else if (third == 3)
                    {
                        if (four == 1)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 2)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 3)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                    }
                }
                else if (second == 3)
                {
                    if (third == 1)
                    {
                        if (four == 1)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 2)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 3)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                    }
                    else if (third == 2)
                    {
                        if (four == 1)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 2)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 3)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                    }
                    else if (third == 3)
                    {
                        if (four == 1)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 2)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 3)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                    }
                }
            }
            // Вторая ветка B_1
            else if (first == 2)
            {
                if (second == 1)
                {
                    if (third == 1)
                    {
                        if (five == 1)
                        {
                            ActTextPresents.TextPresents("История 5.1a ");
                        }
                        else if (five == 2)
                        {
                            ActTextPresents.TextPresents("История 5.2a ");
                        }
                        else if (five == 3)
                        {
                            ActTextPresents.TextPresents("История 5.3a ");
                        }
                    }
                    else if (third == 2)
                    {
                        if (five == 1)
                        {
                            ActTextPresents.TextPresents("История 5.1a ");
                        }
                        else if (five == 2)
                        {
                            ActTextPresents.TextPresents("История 5.2a ");
                        }
                        else if (five == 3)
                        {
                            ActTextPresents.TextPresents("История 5.3a ");
                        }
                    }
                    else if (third == 3)
                    {
                        if (five == 1)
                        {
                            ActTextPresents.TextPresents("История 5.1a ");
                        }
                        else if (five == 2)
                        {
                            ActTextPresents.TextPresents("История 5.2a ");
                        }
                        else if (five == 3)
                        {
                            ActTextPresents.TextPresents("История 5.3a ");
                        }
                    }
                }
                else if (second == 2)
                {
                    if (third == 1)
                    {
                        if (five == 1)
                        {
                            ActTextPresents.TextPresents("История 5.1a ");
                        }
                        else if (five == 2)
                        {
                            ActTextPresents.TextPresents("История 5.2a ");
                        }
                        else if (five == 3)
                        {
                            ActTextPresents.TextPresents("История 5.3a ");
                        }
                    }
                    else if (third == 2)
                    {
                        if (five == 1)
                        {
                            ActTextPresents.TextPresents("История 5.1a ");
                        }
                        else if (five == 2)
                        {
                            ActTextPresents.TextPresents("История 5.2a ");
                        }
                        else if (five == 3)
                        {
                            ActTextPresents.TextPresents("История 5.3a ");
                        }
                    }
                    else if (third == 3)
                    {
                        if (five == 1)
                        {
                            ActTextPresents.TextPresents("История 5.1a ");
                        }
                        else if (five == 2)
                        {
                            ActTextPresents.TextPresents("История 5.2a ");
                        }
                        else if (five == 3)
                        {
                            ActTextPresents.TextPresents("История 5.3a ");
                        }
                    }
                }
                else if (second == 3)
                {
                    if (third == 1)
                    {
                        if (five == 1)
                        {
                            ActTextPresents.TextPresents("История 5.1a ");
                        }
                        else if (five == 2)
                        {
                            ActTextPresents.TextPresents("История 5.2a ");
                        }
                        else if (five == 3)
                        {
                            ActTextPresents.TextPresents("История 5.3a ");
                        }
                    }
                    else if (third == 2)
                    {
                        if (five == 1)
                        {
                            ActTextPresents.TextPresents("История 5.1a ");
                        }
                        else if (five == 2)
                        {
                            ActTextPresents.TextPresents("История 5.2a ");
                        }
                        else if (five == 3)
                        {
                            ActTextPresents.TextPresents("История 5.3a ");
                        }
                    }
                    else if (third == 3)
                    {
                        if (five == 1)
                        {
                            ActTextPresents.TextPresents("История 5.1a ");
                        }
                        else if (five == 2)
                        {
                            ActTextPresents.TextPresents("История 5.2a ");
                        }
                        else if (five == 3)
                        {
                            ActTextPresents.TextPresents("История 5.3a ");
                        }
                    }
                }
            }
            // Третья  ветка C_1
            else if (first == 3)
            {
                if (second == 1)
                {
                    if (third == 1)
                    {
                        if (four == 1)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 2)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 3)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }

                    }
                    else if (third == 2)
                    {
                        if (four == 1)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 2)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 3)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                    }
                    else if (third == 3)
                    {
                        if (four == 1)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 2)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 3)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                    }
                }
                else if (second == 2)
                {
                    if (third == 1)
                    {
                        if (four == 1)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 2)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 3)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                    }
                    else if (third == 2)
                    {
                        if (four == 1)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 2)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 3)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                    }
                    else if (third == 3)
                    {
                        if (four == 1)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 2)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 3)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                    }
                }
                else if (second == 3)
                {
                    if (third == 1)
                    {
                        if (four == 1)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 2)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 3)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                    }
                    else if (third == 2)
                    {
                        if (four == 1)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 2)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 3)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                    }
                    else if (third == 3)
                    {
                        if (four == 1)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 2)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                        else if (four == 3)
                        {
                            if (five == 1)
                            {
                                ActTextPresents.TextPresents("История 5.1a ");
                            }
                            else if (five == 2)
                            {
                                ActTextPresents.TextPresents("История 5.2a ");
                            }
                            else if (five == 3)
                            {
                                ActTextPresents.TextPresents("История 5.3a ");
                            }
                        }
                    }
                }
            }
        }
    }
}