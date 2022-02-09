using System;

namespace OneToTen
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm kuvab konsoolis numbreid 1 kuni 10

            for (int i = 0; i < 10; i++) //int i = 0 (interatsiooni algus) ; i < 10 (interatsiooni lõpp, tsükli panen seisma seal) ; i++ = i + 1 (tuleb tsüklisse 1 korra alati).
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
