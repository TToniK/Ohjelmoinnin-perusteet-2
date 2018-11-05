using System;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Ohjelma laskee N ensimmäistä lukua yhteen.");
                Console.WriteLine("Syötä luku: ");

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
                        i++;
                        F += i;
                    }

                    Console.WriteLine($"Vastaus: {F}");
                    Console.ReadKey();
                }
            }
        }
    }
}
