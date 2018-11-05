using System;

namespace _4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Ohjelma heittää kolikkoa 20 kertaa ja\nkertoo, kuinka monta kruunaa ja klaavaa tuli.");
                int kruuna = 0;
                int klaava = 0;

                Random rnd = new Random();
                double flip;

                for (int i = 0; i != 20; i++)
                {
                    flip = rnd.NextDouble();

                    if (flip > 0.5)
                    {
                        kruuna++;
                    }
                    else
                    {
                        klaava++;
                    }

                }

                Console.WriteLine($"Kruunia: {kruuna}   Klaavoja: {klaava}");
                Console.ReadKey();
            }
        }
    }
}