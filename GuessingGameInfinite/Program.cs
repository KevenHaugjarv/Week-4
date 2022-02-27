using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis numbri ära arvata siis on kasutaja mängu võitnud;
            //katsete arv on piiramatu;
            //*programm genereerib juhuslikku numbrit ühe korra;

            Random userRandom = new Random();
            int cpuNumber = userRandom.Next(1, 11);
            int i = 0;
            while (i != 9)
            {
                Console.WriteLine("Sisesta number");
                int myRandomNumber = Convert.ToInt32(Console.ReadLine());
                if (myRandomNumber == 9)
                    Console.WriteLine("Õige vastus, Jätka samas vaimus!");
                else
                {
                    Console.WriteLine("vale");
                }

                
            }
           
            }



        }

           





        }
    

