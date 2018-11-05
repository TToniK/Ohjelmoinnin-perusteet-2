using System;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            int i = 1;
            int evenSum = 0;
            int oddSum = 0;
            

            Console.WriteLine("Ohjelma laskee parittomien ja parillisten lukujen summan.");
            Console.Write("Syötä luku: ");
            input = int.Parse(Console.ReadLine());

            while (i <= input)
            {
                if (i % 2 == 0)
                {
                    evenSum = evenSum + i;
                }
                else
                {
                    oddSum = oddSum + i;
                }
                i++;
            }
            Console.WriteLine($"parillisten summa on {evenSum}");
            Console.WriteLine($"parittomien summa on {oddSum}");
            Console.ReadKey();

        }
    }
}