using System;

namespace Ifharj4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] a = new int[30];
            Console.Write("Kuinka monta lukua haluat laittaa järjestykseen? : ");

            int n = Convert.ToInt16(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                Console.Write("Syötä nro " + i + ":");

                a[i] = Convert.ToInt16(Console.ReadLine());
            }

            for (i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }

            Console.Write("Nouseva järjestys : ");
            for (i = 1; i <= n; i++)
            {
                Console.Write(a[i] + " ");
                Console.ReadKey();
            }
        }
    }
}
