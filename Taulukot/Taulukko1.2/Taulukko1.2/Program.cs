using System;
using System.Linq;
using System;

namespace Taulukko1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Random keskiarvo");
                int[] iT = new int[100];
                Random rnd = new Random();
                
                for (int i = 0; i < iT.Length; i++)
                {
                    iT[i] = rnd.Next(50);
                }
                
                int summa = iT.Sum();
                int average = summa / 100;
                
                for (int i = 0; i < iT.Length; i++)
                {
                    Console.Write($"{i + 1}. ");
                    Console.WriteLine(iT[i]);
                }
                Console.WriteLine($"keskiarvo: {average}");
                Console.ReadKey();
            }
        }
    }
}