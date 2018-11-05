using System;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Ohjelma laskee N:n kertymän (N!)");
                Console.WriteLine("Anna luku: ");

                while (true)
                {


                    int number;

                    do
                    {

                        number = int.Parse(Console.ReadLine());

                    } while (number <= 0);

                    double i = 1;
                    double F = 1;

                    while (i != number)
                    {
                        i = i + 1;
                        F = F * i;
                    }
                    
                    Console.WriteLine($"Vastaus: {F}");
                    Console.ReadKey();
                }
            }
        }
    }
}
