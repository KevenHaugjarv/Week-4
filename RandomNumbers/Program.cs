using System;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kui genereeritud number on 5, siis programm lõpetab oma töö ja soovib kasutajale "kena päeva";
            //kui genereeritud number on midagi muud, siis programm jätkab tööd;

            Random userRandom = new Random();
            int i = 0;
            while (i != 5)
            {
                int myRandomNumber = userRandom.Next(1, 11);
                Console.WriteLine($"Juhuslik number on {myRandomNumber}");
                if(myRandomNumber == 5)
                {
                    i = myRandomNumber;
                }
            }
            Console.WriteLine("Kena Päeva!");

            //Console.WriteLine($"Juhuslik number on {myRandomNumber}");



        }
    }
}
