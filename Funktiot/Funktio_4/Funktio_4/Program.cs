using System;

namespace Funktio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int indx = 0;
            Console.WriteLine("Syötä 10 lukua: ");
            Console.WriteLine($"Suurin luku {LargesNumber(ref indx)} oli {indx}.luku");
            Console.ReadKey();
        }
        static int LargesNumber(ref int indx)
        {
            int LargesNumber = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}.luku: ");
                int userNumber = int.Parse(Console.ReadLine());
                if (userNumber < 0)
                {
                    Console.WriteLine("Syötä positiivinen luku!");
                    i--;
                }

                if (userNumber > LargesNumber)
                {
                    LargesNumber = userNumber;
                    indx = i + 1;
                }
                
            }
            return LargesNumber;
            
        }
    }
    
}
