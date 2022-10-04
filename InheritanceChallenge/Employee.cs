using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge
{
    public class Employee
    {
        protected string name;
        protected string firstName;
        protected int salary;

        public Employee()
        {
            this.name = "Doe";
            this.firstName = "John";
            this.salary = 0;
        }

        public Employee(string Name, string Firstname, int salary)
        {
            this.name = Name;
            this.firstName = Firstname;
            this.salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine("I am working...");
        }

        public virtual void Pause()
        {
            Console.WriteLine("Break from Work...");
        }
    }
}
