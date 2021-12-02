using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee ("CEO", "Gwyn", 95,200),
                new Employee("Manager", "Joe", 35,25),
                new Employee("HR", "Lora", 32,21),
                new Employee("Secretary", "Petra",28,18),
                new Employee("Lead Developer", "Artorias", 55,35),
                new Employee("Intern", "Ernest",22,8),
            };


            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                {1,"one"},
                {2,"two"},
                {3,"three"}
            };

            Dictionary<string, Employee> employeesDictionary = new Dictionary<string, Employee>();

            foreach(Employee emp in employees)
            {
                employeesDictionary.Add(emp.Role, emp);
            }

            for (int i = 0; i<employeesDictionary.Count; i++)
            {
                // using ElementAt(i) to return key-value pair started at index 1
                KeyValuePair<string, Employee> keyValuePair = employeesDictionary.ElementAt(i);
                // print the key
                Console.WriteLine("Key {0}",keyValuePair.Key);
                // storing the value in an employee object
                Employee employeeValue = keyValuePair.Value;
                // printing the properties of the emplooye object
                Console.WriteLine("Employee Name: {0}", employeeValue.Name);
                Console.WriteLine("Employee Role: {0}", employeeValue.Role);
                Console.WriteLine("Employee Age: {0}", employeeValue.Age);
                Console.WriteLine("Employee Salary: {0}", employeeValue.Salary);
            }

            string key = "CEO";
            if (employeesDictionary.ContainsKey(key))
            {
                Employee empl = employeesDictionary["CEO"];
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", empl.Name, empl.Role, empl.Salary);
            } else
            {
                Console.WriteLine("No employees were found with this Key {0}", key);
            }

            

        }
    }

    class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }
        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
}
