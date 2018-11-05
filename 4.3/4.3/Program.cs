using System;

namespace _4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndnumber;
            Console.WriteLine("\n20 satunnaista numeroa 1-50 väliltä:");
            Console.WriteLine();
            for (int r = 1; r <= 4; r++)
            {
                Console.Write($"\nRivi {r}: ");
                for (int i = 0; i < 5; i++)
                {
                    rndnumber = rnd.Next(0, 51);
                    Console.Write($"{rndnumber}\t");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}