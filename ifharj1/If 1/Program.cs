using System;

namespace Vuokaavio1
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.WriteLine("Anna luku: ");
            int luku = Convert.ToInt32(Console.ReadLine());
            if (luku == 0)
                Console.WriteLine(luku + " on nolla");
            if (luku > 0)
                Console.WriteLine(luku + " on positiivinen");
            if (luku < 0)
                Console.WriteLine(luku + " on negatiivinen");
            Console.ReadKey();
                           
            
        }
    }
}
