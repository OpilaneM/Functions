﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNameData
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajal sisestada oma eesnime
            //Programm kuvab kasutaja eesnime pikkust
            //Programm kuvab kasutaja eesnime esimest t2hte
            //porgramm kuvab kasutaja eesnime tagurpidi
            //main meetodis ei tohi olla rohkem, kui kolm rida koodi

            Console.WriteLine("Sisesta oma eesnimi:");
            String userName = Console.ReadLine();
            GetUserNameData(userName);
        }
        public static void GetUserNameData(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk");
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
            for (int i = userInput.Length - 1; i >=0; i--)
            {
                Console.Write(userInput[i]);
            }
            Console.Read();
        }

    }
}