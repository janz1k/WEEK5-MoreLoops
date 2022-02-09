using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //I will not skateboard in the halls.



            for (int i = 0; i < 10; i++) //int i = 0 (interatsiooni algus) ; i < 10 (interatsiooni lõpp, tsükli panen seisma seal) ; i++ = i + 1 (tuleb tsüklisse 1 korra alati).
            {
                Console.WriteLine($"{i+1}.I will not skateboard in the halls.".ToUpper());
            }

            Console.WriteLine("Kena päeva!");


        }
    }
}
