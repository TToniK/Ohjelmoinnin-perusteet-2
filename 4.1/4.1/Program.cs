﻿using System;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Random rnd = new Random();
                int rndNumber;

                Console.WriteLine("Ohjelma tulostaa 10 arvottua kokokonaislukua ja niiden neliöjuuret");
                Console.WriteLine("#\tluku\tneliöjuuri");

                int i = 0;
                while (i < 10)
                {
                    rndNumber = rnd.Next(2, 10);
                    Console.WriteLine($"{i + 1}.\t{rndNumber}\t{Math.Sqrt(rndNumber)}");
                    i = i + 1; //i++
                }
            }Console.ReadKey();
        }
    }
}