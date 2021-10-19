using System;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!"
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."

            //OR ehk või ehk ||
            
            //true || true --> TRUE
            //false || true --> TRUE
            //true || false --> TRUE
            //false || false --> FALSE

            Console.WriteLine("Sisesta kasutajatunnus:");
            string userNamer = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string userPassword = Console.ReadLine();

            if(userNamer != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
            }

            else
            {
                Console.WriteLine("Tere tulemast!");
            }

            // "admin1" != "admin" || "admin1234" != "admin1234" --> true || false --> TRUE
            // "admin" != "admin" || "admin123" != "admin1234" --> false || true --> TRUE
            // "admin1" != "admin" || "admin123" != "admin1234" --> true || true --> TRUE
            // "admin" != "admin" || "admin1234" != "admin1234" --> false || false --> FALSE

        }
    }
}
