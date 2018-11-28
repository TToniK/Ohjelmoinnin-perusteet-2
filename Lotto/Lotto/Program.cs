using System;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo lottonumerot sekä lisänumeron\nettä plusnumeron ja tulostaa ne.");
            int[] numerot = new int[40];
            Random rnd = new Random();

            for (int i = 0; i < 7; i++)
            {
                int rndNumber = rnd.Next(40);
                if (numerot[rndNumber] == 0)
                    numerot[rndNumber] = 1;
                else
                    i--;
            }

            while (true)
            {
                int rndNumber = rnd.Next(40);
                if (numerot[rndNumber] == 0)
                {
                    numerot[rndNumber] = 2;
                    break;
                }
            }
            int plusNumber = rnd.Next(40) + 1;

            Console.Write("Arvotut numerot: ");
            for (int i = 0; i < numerot.Length; i++)
            {
                if (numerot[i] == 1)
                    Console.Write($"{i + 1} ");

            }

            for (int i = 0; i < numerot.Length; i++)
            {
                if (numerot[i] == 2)
                    Console.WriteLine($"\nLisänumero: {i + 1}");

            }
            Console.WriteLine($"Plussanumero: {plusNumber}");
            Console.ReadKey();
            
        }
    }
}