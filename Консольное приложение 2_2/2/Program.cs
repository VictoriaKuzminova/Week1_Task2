using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int kol_vo_day;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите количество прощедших дней: ");
                    kol_vo_day = int.Parse(Console.ReadLine());
                    if (kol_vo_day < 0)
                    {
                        Console.WriteLine("Количество не может быть меньше 0");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод!");
                }
            }
            DateTime start = new DateTime(1990, 1, 1);
            DateTime finish = start.AddDays(kol_vo_day); //добавляем дни
            int month = finish.Month; //получаем месяцы
            string s_month = "";
            switch (month)
            {
                case 1: s_month = "Январь"; break;
                case 2: s_month = "Февраль"; break;
                case 3: s_month = "Март"; break;
                case 4: s_month = "Апрель"; break;
                case 5: s_month = "Май"; break;
                case 6: s_month = "Июнь"; break;
                case 7: s_month = "Июль"; break;
                case 8: s_month = "Август"; break;
                case 9: s_month = "Сентябрь"; break;
                case 10: s_month = "Октябрь"; break;
                case 11: s_month = "Ноябрь"; break;
                case 12: s_month = "Декабрь"; break;
            }
            Console.WriteLine("Текущий месяц: "+s_month);
            Console.ReadLine();
        }
    }
}
