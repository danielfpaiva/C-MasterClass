using System;

namespace InheritanceChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Paiva", "Daniel", 5000);
            Boss boss = new Boss("Jesus","Jorge",50000,"Tesla");
            Trainee trainee = new Trainee("Paiva", "Matilde",100,10,15);

            employee.Work();
            boss.Lead();
            employee.Pause();
            trainee.Work();
        }
    }
}
