using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int rn = r.Next(0, 101);

            while (true)
            {
                string t = Console.ReadLine();
                int mn = Convert.ToInt32(t);

                if (rn > mn)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else if (rn < mn)
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
                else if (rn == mn)
                {
                    Console.WriteLine("Вы выиграли!");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}