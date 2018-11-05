using System;

namespace vuokaavio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku: ");
            int luku = Convert.ToInt32(Console.ReadLine());
            {
                
                    if (luku == 0)
                        Console.WriteLine("Luku on nolla");
                    
                else
                {
                    {
                        if (luku % 2 == 0)
                        {
                            Console.WriteLine("Luku on parillinen");
                        }
                        else
                        {
                            Console.WriteLine("luku on pariton");
                        }
                    }


                    {
                        
                        if (luku < 0)
                            
                        {
                            Console.WriteLine("sekä negatiivinen");
                            
                        }
                        else
                        {
                            Console.WriteLine("sekä positiivinen");
                        }
                    }







                    


                }
                Console.ReadKey();
            }
        }
    }
}
