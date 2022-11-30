    using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            while (true)
            {
                try
                {
                    Console.Write("Введите координату x: ");
                    x = float.Parse(Console.ReadLine());
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
                    Console.Write("Введите координату y: ");
                    y = float.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод!");
                }

            }

            if (y >= Math.Abs(x) && x * x + y * y <=225 )
            {
                if (y>Math.Abs(x) && x * x + y * y < 225)
                    Console.WriteLine("Да");
                else
                    Console.WriteLine("На границе");
            }
            else
                Console.WriteLine("Нет");
        }
    }
}
