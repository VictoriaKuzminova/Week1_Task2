using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            for (int i = 1; i <= 5; ++i, Console.WriteLine())
            {
                for(int j = 1; j <= a; j++)
                {
                    Console.Write(" "+i);
                }
                a++;
            }
        }
    }
}
