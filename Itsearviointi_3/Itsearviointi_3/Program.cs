<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Itsearviointi_3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Ohjelma laskee syötetyt luvut yhteen niin kauan kunnes syötät luvun -1 .");
                int stop = 0;
                List<int> list = new List<int>();
                do
                {
                    Console.Write("Syötä luku:  ");
                    string userInput = Console.ReadLine();
                    Console.WriteLine();
                    int num;
                    while (!Int32.TryParse(userInput, out num))
                    {
                        Console.WriteLine("Virheellinen syöte. Syötä luku: ");
                        userInput = Console.ReadLine();
                    }
                    if (num != -1)
                    {
                        list.Add(num);
                    }
                    else
                    {
                        stop++;
                    }

                } while (stop == 0);
                double sum = list.Sum();
                Console.WriteLine($"Syötettyjen lukujen summa: {sum}");
                Console.ReadKey();
            }
        }
    }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Itsearviointi_3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Ohjelma laskee syötetyt luvut yhteen niin kauan kunnes syötät luvun -1 .");
                int stop = 0;
                List<int> list = new List<int>();
                do
                {
                    Console.Write("Syötä luku:  ");
                    string userInput = Console.ReadLine();
                    Console.WriteLine();
                    int num;
                    while (!Int32.TryParse(userInput, out num))
                    {
                        Console.WriteLine("Virheellinen syöte. Syötä luku: ");
                        userInput = Console.ReadLine();
                    }
                    if (num != -1)
                    {
                        list.Add(num);
                    }
                    else
                    {
                        stop++;
                    }

                } while (stop == 0);
                double sum = list.Sum();
                Console.WriteLine($"Syötettyjen lukujen summa: {sum}");
                Console.ReadKey();
            }
        }
    }
>>>>>>> 93347cb67d5e1ca63a8b175471708894e5894679
}