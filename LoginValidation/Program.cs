using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!"
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."
            //kasutajal on 3 katset

            

            int i = 0;

            while (i < 3)
            {

                Console.WriteLine("Sisesta kasutajatunnus:");
                string userNamer = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna:");
                string userPassword = Console.ReadLine();

                if (userNamer == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;

                }
                else
                {
                    Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
                }
                i++;
                {
                    Console.WriteLine($"{3 - i} katset on jäänud.");
                }
            }
        }
    }
}
