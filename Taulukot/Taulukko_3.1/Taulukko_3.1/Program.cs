using System;

namespace Taulukko_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Ohjelma arpoo 10 lukua ja esittää ne taulukossa");
                int[] arr = new int[10];
                Random rnd = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(20);
                }
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.WriteLine($"[{j}] = {arr[j]:D2}");
                }
            }Console.ReadKey();
        }
    }
}