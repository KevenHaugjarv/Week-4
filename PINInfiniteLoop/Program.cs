using System;

namespace PINInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN-koodi;
            //programm võrdleb sisestatud PIN-kood arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast";
            //kui sisestatud Pin-kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti";
            //katsete arv on piiramatu.

            bool loopActive = true;
            int i = 0;

            while(loopActive)
            {
                Console.WriteLine("Sisesta PIN");
                int userPin = Convert.ToInt32(Console.ReadLine());

                if(userPin == 1234)
                {
                    Console.WriteLine("Tere tulemast");
                    loopActive = false;
                }

                else
                {
                    i++;
                    Console.WriteLine("Vale PIN. proovi uuesti!");
                    Console.WriteLine($"Oled vale PIN-koodi {i} korda sisestada");
                }

            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
