using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int kol_vo=10;
            float x;
            int str;
            while (true)
            {
                try
                {
                    Console.Write("Введите стоимость товара: ");
                    x = float.Parse(Console.ReadLine());
                    if (x <= 0)
                    {
                        Console.WriteLine("Цена не может быть меньше или равна 0!");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод!");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Введите количество строк: ");
                    str = int.Parse(Console.ReadLine());
                    if ((str <= 0)||(str>10))
                    {
                        Console.WriteLine("Количество строк не может принимать данное значение");
                        continue;
                    }
            
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод!");
                }
            }
            Console.WriteLine("\n");
            while (kol_vo <=str*10)
            {
                Console.WriteLine("Количество "+kol_vo+"  стоят "+kol_vo*x+" руб");
                kol_vo += 10;
            }
            Console.WriteLine("\n");
            kol_vo = 10;
            do
            {
                Console.WriteLine("Количество " + kol_vo + "  стоят " + kol_vo * x + " руб");
                kol_vo += 10;
            } while (kol_vo <= str*10);
            Console.WriteLine("\n");
            
            for(int i = 10; i <= str*10; i += 10)
            {
                Console.WriteLine("Количество " + i + "  стоят " + i * x + " руб");
            }
        }
    }
}
