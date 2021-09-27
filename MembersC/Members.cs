using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MembersC
{
    class Members
    {
        //member - private field
        private string memberName;
        private string jobTitle;
        private int salary;

        // member - public field
        public int age;

        //member - property - exposes jobTitle safely - properties start with capital letter
        public string JobTitle
        {
            get 
            {
                return jobTitle;
            }
            set 
            {
                jobTitle = value;
            }
        }

        //public member method - can be called for other classes
        public void Introducing (bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("My name is {0} and my job title is {1}", memberName,jobTitle);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        // member constructor
        public Members()
        {
            age = 30;
            memberName = "Daniel";
            jobTitle = "Software Developer";
            salary = 60000;
            Console.WriteLine("Object created");
        }

        //member - finalizer - destructor
        ~Members()
        {
            // cleanup statements
            Console.WriteLine("Deconstruction of member object");
            Debug.Write("Deconstruction of member object");
        }
    }
}
