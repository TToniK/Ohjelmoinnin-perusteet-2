using System;

namespace Viitenumero
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("1. Ohjelma tarkistaa kotimaisen viitenumeron\n" +
                                  "2. Ohjelma luo uuden kotimaisen viitenumeron");
                Console.Write("Syötä numero [1] tai [2] ja paina enter: ");
                int choice = int.Parse(Console.ReadLine());

                do
                {
                    switch (choice)
                    {
                        case 1:
                            CheckRefNum();
                            break;
                        case 2:
                            RefNumCreate();
                            break;
                        
                        default:
                            Console.Write("Virheellinen syöte! Valitse 1 tai 2:");
                            break;
                    }
                } while (choice != 1 || choice != 2);
            }
        }
        
        static void CheckRefNum()
        {
                Console.WriteLine("Syötä kotimainen viitenumero: ");

                string refNum = Console.ReadLine();
                if (refNum == "")
                {
                     Console.WriteLine("Et syöttänyt mitään");
                     Console.ReadKey();
                }
                else if (refNum[0] == '0')
                {
                     Console.WriteLine("Viitenumero ei voi alkaa numerolla 0.");
                }
               
                int sum = 0;
                int[] multiplier = new int[] { 7, 3, 1 };
                int[] refArr = new int[refNum.Length];
                for (int i = 0; i < refNum.Length; i++)
                {
                    refArr[i] = int.Parse(refNum[i].ToString());
                }
                for (int i = 0; i < refArr.Length - 1; i++)
                {
                    sum += refArr[refArr.Length - 2 - i] * multiplier[i % 3];
                }
                int checkNum = 10 - (sum % 10);
                if (checkNum == 10)
                {
                    checkNum = 0;
                }

                else if (refArr[refArr.Length - 1] == checkNum)
                {
                    Console.WriteLine($"{refNum} on oikein.");
                  
                }
                else
                {
                    Console.WriteLine($"{refNum} on väärin.");
                  
                }
        }

        static void RefNumCreate()
        {
            string refNumInput;

            Console.WriteLine("Syötä viitenumeron alkuosa, joka on 3-19 merkkiä pitkä:");
            refNumInput = Console.ReadLine();
            if (refNumInput.Length >= 19)
            {
                Console.WriteLine("Liian pitkä syöte");
            }
            else if (refNumInput.Length <= 3)
            {
                Console.WriteLine("Liian lyhyt syöte");
            }
            else
            {

                int sum = 0;
                int[] multiplier = new int[] { 7, 3, 1 };
                int[] refArr = new int[refNumInput.Length];
                for (int i = 0; i < refNumInput.Length; i++)
                {
                    refArr[i] = int.Parse(refNumInput[i].ToString());
                }
                for (int i = 0; i < refArr.Length; i++)
                {
                    sum += refArr[refArr.Length - 1 - i] * multiplier[i % 3];
                }
                int checkNum = 10 - (sum % 10);
                if (checkNum == 10)
                {
                    checkNum = 0;
                }
                Console.WriteLine($"Syöte: {refNumInput}");

                string refNumOutput = refNumInput + checkNum;
                for (int i = 1; i < refNumOutput.Length; i++)
                {
                    if (i % 5 == 0)
                    {
                        refNumOutput = refNumOutput.Insert(i, " ");
                    }
                }
                Console.WriteLine($"Uusi viitenumero on {refNumOutput}");
            }
        }
    }
}