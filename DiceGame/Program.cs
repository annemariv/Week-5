using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user);
            //mõlemad mngijad viskavad täringut;
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija, kes viskab rohkem, on võtja
            //*täringuid visatakse kolm korda
            //programm kuulutab võtija

           

            
            
            
            Random rnd = new Random();

            //arvuti vise
            int cpuRandom = rnd.Next(1, 7);

            //kasutaja vise
            int userRandom = rnd.Next(1, 7);


            int cpuScore = 0;
            int userScore = 0;


            for (int i = 0; i < 3; i++)
            {



                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");


                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
                    userScore = userScore + 1;

                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti on võitnud.");
                    cpuScore = cpuScore + 1;

                }
                else
                {
                    Console.WriteLine("Viik!");

                }
                
            }
        }
    }
}
