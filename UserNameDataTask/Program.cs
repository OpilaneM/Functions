using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm küsib kasutajal sisestada numbrid 1-3
            //kui kasutaja sisestab '1' siis kuvatakse kasutaja eesnime tagurpidi
            //kui kasutaja valib '2' siis kuvatakse kasutaja eesnime esimest tähte
            //kui kasutaja valib 3 siis kuvatakse kasutaja eesnime pikkust


            Console.WriteLine("Sisesta oma eesnimi");
            String userName = Console.ReadLine();
            Console.WriteLine("Sisesta number 1-3");
            char userNumber = Convert.ToChar(Console.ReadLine());

            switch (userNumber)
            {
                case '1':
                    backwards(userName);
                    Console.Read();
                    break;
                case '2':
                    firstLetter(userName);
                    break;
                case '3':
                    nameLenght(userName);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    Console.Read();
                    break;
             }
        }
        public static void backwards(string userName)
        {
            for (int i = userName.Length -1; i >=0; i--)
            {
                Console.WriteLine(userName[i]);
            }
            Console.Read();
        }
        public static void firstLetter(string userName)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userName[0]}");
            Console.Read();

        }
        public static void nameLenght(string userName)
        {
            Console.WriteLine($"Sinu nimi on {userName.Length} sümbolit pikk");
            Console.Read();
        }

    }
}
