<<<<<<< HEAD
﻿using System;

namespace Itsearviointi_1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Ohjelma tulostaa syötteen viisi kertaa.");
                Console.Write("Kirjoita jotain: ");
                string input = Console.ReadLine();
                for (int i = 1; i < 6; i++)
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

namespace Itsearviointi_1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Ohjelma tulostaa syötteen viisi kertaa.");
                Console.Write("Kirjoita jotain: ");
                string input = Console.ReadLine();
                for (int i = 1; i < 6; i++)
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