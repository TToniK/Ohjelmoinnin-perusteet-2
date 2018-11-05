<<<<<<< HEAD
﻿using System;

namespace Itsearviointi_2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Ohjelma tulostaa syötteen niin monta kertaa kuin kirjaimia on syötteessä.");
                Console.Write("Kirjoita jotain: ");
                string input = Console.ReadLine();
                int numberOfLetters = 0;
                foreach (char letter in input)
                {
                    numberOfLetters++;
                }
                for (int i = 1; i < numberOfLetters + 1; i++)
                {
                    Console.Write($"{i}. ");
                    Console.WriteLine(input);
                }
                Console.ReadLine();
            }
        }
    }
=======
﻿using System;

namespace Itsearviointi_2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Ohjelma tulostaa syötteen niin monta kertaa kuin kirjaimia on syötteessä.");
                Console.Write("Kirjoita jotain: ");
                string input = Console.ReadLine();
                int numberOfLetters = 0;
                foreach (char letter in input)
                {
                    numberOfLetters++;
                }
                for (int i = 1; i < numberOfLetters + 1; i++)
                {
                    Console.Write($"{i}. ");
                    Console.WriteLine(input);
                }
                Console.ReadLine();
            }
        }
    }
>>>>>>> 93347cb67d5e1ca63a8b175471708894e5894679
}