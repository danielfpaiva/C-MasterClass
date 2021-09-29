using System;
using System.Collections;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);

            Hashtable xpto = new Hashtable();

            foreach (Student student in students)
            {
                if (xpto.ContainsKey(student.Id))
                {
                    Console.WriteLine("Sorry, A student with the ID {0} already exists.",student.Id);
                }
                else
                {
                    xpto.Add(student.Id, student);
                }
            }

            Console.WriteLine("\n");

            foreach (Student value in xpto.Values)
            {
                Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}", value.Id, value.Name, value.GPA);
            }




            //    // initial a hashtable
            //    Hashtable studentsTable = new Hashtable();

            //    Student stud1 = new Student(1,"Maria",98);
            //    Student stud2 = new Student(2, "Jason", 76);
            //    Student stud3 = new Student(3, "Clara", 43);
            //    Student stud4 = new Student(4, "Steve", 55);

            //    studentsTable.Add(stud1.Id, stud1);
            //    studentsTable.Add(stud2.Id, stud2);
            //    studentsTable.Add(stud3.Id, stud3);
            //    studentsTable.Add(stud4.Id, stud4);

            //    // retrieve individual item with known ID
            //    Student storedStudent1 = (Student)studentsTable[stud1.Id];

            //    // retrieve all values from hashtable
            //    foreach (DictionaryEntry entry in studentsTable)
            //    {
            //        Student temp = (Student)entry.Value;
            //        Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}", temp.Id, temp.Name, temp.GPA);

            //    }

            //    Console.WriteLine("\n");

            //    foreach (Student value in studentsTable.Values)
            //    {
            //        Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}", value.Id, value.Name, value.GPA);
            //    }

            //    Console.WriteLine("\n");

            //    Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);
            //    Console.ReadKey();
            //}
        }

        class Student
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public float GPA { get; set; }

            public Student(int id, string name, float GPA)
            {
                this.Id = id;
                this.Name = name;
                this.GPA = GPA;
            }
        }
    }
}
