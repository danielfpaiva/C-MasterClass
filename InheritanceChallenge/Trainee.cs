using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge
{
    class Trainee : Employee
    {
        protected int workingHours;
        protected int schoolHours;

        public Trainee() { }

        public Trainee(string name, string Firstname, int salary, int workinghours, int schoolhours)
        {
            this.name = name;
            this.firstName = Firstname;
            this.salary = salary;
            this.workingHours = workinghours;
            this.schoolHours = schoolhours;
        }

        public override void Work()
        {
            workingHours++;
            Console.WriteLine("I have {0} working hours.",workingHours);
        }
    }
}
