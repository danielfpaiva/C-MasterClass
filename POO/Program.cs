using System;

namespace POO
{
    static class Program
    {
        static void Main(string[] args)
        {
            /*// create an object of my class
            // an instance of Human()
            Human denis = new Human();
            // access public variable from outside, and even change it
            denis.firstName = "Denis";
            // call methods of the class
            denis.IntroduceMySelf();*/

            /*Human michael = new Human();
            michael.firstName = "Mike";
            michael.IntroduceMySelf();*/

            Human sissy = new Human("Sissy", "Wagner", "Brown", 20);
            //sissy.firstName = "Sissy";
            //sissy.lastName = "Wagner";

            sissy.IntroduceMySelf();

            Human peter = new Human("Peter", "Keeper", "Blue", 1);
            peter.IntroduceMySelf();
        }
    }
}
