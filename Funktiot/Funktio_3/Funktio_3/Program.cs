﻿using System;

namespace Funktio_3
{
    class Program
    {
        static void Main(string[] args)
        {
           int retNumber = NumberFromRange(-10, 10);
            Console.WriteLine($"Syötit sallitun luvun {retNumber}");
            Console.ReadKey();
        }

        static int NumberFromRange(int lowerBound, int upperBound)
        {
            
                do
                {
                    Console.WriteLine($"Syötä luku alueelta {lowerBound} - {upperBound}");
                    string userInput = Console.ReadLine();
                    bool isNumber = int.TryParse(userInput, out int userNumber);
                    if (isNumber && userNumber >= lowerBound && userNumber <= upperBound)

                        return userNumber;
                    else
                        Console.WriteLine("Väärä syöte!");
                } while (true);
            
            
        }
       
    }
}
        
    