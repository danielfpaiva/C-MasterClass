using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge
{
    class Boss : Employee
    {
        protected string companyCar;

        public Boss() { }

        public Boss(string Name, string Firstname, int salary,string companycar)
        {
            this.name = Name;
            this.firstName = Firstname;
            this.salary = salary;
            this.companyCar = companycar;
        }

        public void Lead()
        {
            Console.WriteLine("I am leading.");
        }
    }
}
