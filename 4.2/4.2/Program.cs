using System;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Ohjelma tulostaa kertotaulun luvuille 1-9.");
                Console.WriteLine();

                for (int i = 1; i <= 9; i++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        Console.Write((i * j).ToString() + "\t");
                    }
                    Console.WriteLine();
                    Console.ReadKey();
                
                }
            }
        }
    }
}