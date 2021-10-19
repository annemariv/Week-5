using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!"
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."

            //AND

            //AND operaator: kas mõlemad avaldised vastavad tõele: 
            // AND ehk &&
            //"admin" AND "admin 1234" --> TRUE
            //"admin1" AND "admin 1234" --> FALSE
            //"admin" AND "admin12345" --> FALSE
            //"admin1" AND "admin12345" --> FALSE



            Console.WriteLine("Sisesta kasutajatunnus:");
            string userNamer = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string userPassword = Console.ReadLine();

            if(userNamer == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
            }


        }
    }
}
