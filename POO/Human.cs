using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    // this class is a blueprint for a datatype
    class Human
    {
        //member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        // constructor - we can have several constructors with different number of arguments and with different behaviours.
        public Human(string myFirstName, string lastName, string eyeColor, int age)
        {
            firstName = myFirstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        // member
        public void IntroduceMySelf()
        {
            if (age == 1)
            {
                Console.WriteLine("Hi, My name is {0} {1}, I have {2} year old and I have {3} eyes.", firstName, lastName, age, eyeColor);
            } else
            {
                Console.WriteLine("Hi, My name is {0} {1}, I have {2} years old and I have {3} eyes.", firstName, lastName, age, eyeColor);

            }
        }
    }
}
