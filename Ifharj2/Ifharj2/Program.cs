using System;

namespace Ifharj2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku: ");
            int luku = Convert.ToInt32(Console.ReadLine());
         
            if (luku == 0)
                Console.WriteLine(luku + " on nolla");
            
            else
            {
                if (luku % 2 == 0)
                    Console.WriteLine(luku + " on parillinen");
                else
                    Console.WriteLine(luku + " on pariton");
                
            }
            Console.ReadKey();
        }
       
    }
}
