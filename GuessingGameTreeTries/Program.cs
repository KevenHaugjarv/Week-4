using System;

namespace GuessingGameTreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis numbri ära arvata siis on kasutaja mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata siis mängu võidab arvuti;
            //*programm genereerib juhuslikku numbrit ühe korra;


            Random userRandom = new Random();
            int cpuNumber = userRandom.Next(1, 11);
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Sisesta number");
                int myRandomNumber = Convert.ToInt32(Console.ReadLine());
                if (myRandomNumber == 9)
                    Console.WriteLine("Õige vastus, Jätka samas vaimus!");
                

                else
                {
                    i++;
                    Console.WriteLine("vale");
                }


            }

        }



    }







}