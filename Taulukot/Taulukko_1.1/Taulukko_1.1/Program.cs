using System;

namespace Taulukko_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                decimal[] productPrice = { 7.96m, 72.0m, 99.90m };
                int[] productAmount = { 1, 3, 2 };
                decimal[] productTotalPrice = new decimal[3];
                productTotalPrice[0] = productPrice[0] * productAmount[0];
                productTotalPrice[1] = productPrice[1] * productAmount[1];
                productTotalPrice[2] = productPrice[2] * productAmount[2];


                Console.WriteLine("Tuote 1: " + productTotalPrice[0]);
                Console.WriteLine("Tuote 2: " + productTotalPrice[1]);
                Console.WriteLine("Tuote 3: " + productTotalPrice[2]);



                Console.ReadKey();
            }
        }
    }
}