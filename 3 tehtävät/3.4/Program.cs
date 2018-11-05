using System;

namespace _3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N ensimmäistä lukua yhteen.");
            Console.WriteLine("Syötä luku: ");

            while (true)
            {

                int number;

                do
                {

                    number = int.Parse(Console.ReadLine());

                } while (number == 0);

                double i = 0;
                double F = 0;

                while (i != number)
                {
                    if (number > 0)
                    {
                        i++;
                    }
                    else
                    {
                        i = i - 1;
                    }

                    F += i;
                }
                
                Console.WriteLine($"Vastaus: {F}");
                Console.ReadKey();



            }
        }
    }
}