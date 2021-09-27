using System;

namespace JaggedArraysChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] friendsAndFamily = new string[][]
            {
                new string[]{"Michael", "Sandy"},
                new string[]{"Peter", "Claudia"},
                new string[]{"Andrew", "Michelle"}
            };

            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][0], friendsAndFamily[1][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][1]);
            Console.ReadKey();
        }
    }
}
