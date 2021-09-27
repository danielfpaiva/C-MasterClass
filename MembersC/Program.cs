using System;

namespace MembersC
{
    class Program
    {
        static void Main(string[] args)
        {
            Members member1 = new Members();
            member1.Introducing(false);
            Members member2 = new Members();
            member2.age = 89;
            member2.JobTitle = "Cleaner";
            member2.Introducing(true);
            Console.ReadKey();

        }
    }
}
