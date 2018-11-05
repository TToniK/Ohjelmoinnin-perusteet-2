using System;

namespace LipunHinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olet ostamassa lippua. Vastaa seuraaviin kysymyksiin painamalla K (=kyllä) tai E (=ei)");
            string opiskelija;
            double ale = 0;

            Console.WriteLine("Oletko opiskelija?");

            opiskelija = Console.ReadLine();
            if (opiskelija.ToLower() == "k")
            {
                ale = 45;
            }

            Console.WriteLine("Oletko MTK:n jäsen?");
            string MTK;
            MTK = Console.ReadLine();
            if (MTK.ToLower() == "k")
            {
                ale += 15;
            }

            Console.WriteLine("Oletko varusmies?");
            string varus;
            varus = Console.ReadLine();
            if (varus.ToLower() == "k")
            {
                ale = 50;
            }

            Console.WriteLine("Anna ikäsi numeroina: ");
            string age;

            age = Console.ReadLine();
            int number;
            while (!Int32.TryParse(age, out number))
            {

                Console.WriteLine($"Ikäsi ei voi olla '{age}', anna ikäsi numeroina");
                Console.WriteLine("Anna ikäsi numeroina: ");
                age = Console.ReadLine();

            }
            double hinta = 16;
            if (number < 8)
            {
                ale = 100;
            }
            else if (number > 64)
            {
                ale = 50;
            }
            else if (number > 7 && number < 65)
            {
                hinta = 16;
            }

            hinta = (100 - ale) * hinta / 100;

            if (ale == 0)
            {
                hinta = 16;
            }

            Console.WriteLine($"Lipun hinta on {hinta} euroa.");
            Console.ReadKey();
        }
        
    }

}

