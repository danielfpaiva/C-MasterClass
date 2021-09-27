using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class DataTypesAndDecisions
    {

        /*public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method.");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }*/

        /*public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply (int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Devide (double num1, double num2)
        {
            return num1 / num2;
        }*/

        /*public static void GreetFriend(string name)
        {
            Console.WriteLine("Hi {0}, my friend!",name);
        }*/

        /*public static void LearnTryCatch()
        {
            // Try Catch
Console.WriteLine("Please enter a number");
string userInput = Console.ReadLine();

int num1 = 9;
int num2 = 0;
int result;

try
{
    result = num1 / num2;    
}
catch (DivideByZeroException)
{

    Console.WriteLine("Cannot devide by zero!");
}

try
{
    int userInputAsInt = int.Parse(userInput);
} catch (FormatException)
{
    Console.WriteLine("Format exception!");
} catch (OverflowException)
{
    Console.WriteLine("General Exception.");
}
finally
{
    Console.WriteLine("Always displayed!");
}



Console.ReadKey();
}*/


        /*public static void Termometer()
        {
            Console.WriteLine("What is the temperature now?");
            string userTemperature = Console.ReadLine();
            int temperature = 0;
            int number;

            if (int.TryParse(userTemperature, out number))
            {
                temperature = number;
            } else
            {
                Console.WriteLine("Insert a number valid format!");
                return;
            }

            if (temperature < 10)
            {
                Console.WriteLine("Take the coat because it is {0} degrees Cª.", temperature);
            } else if (temperature > 20)
            {
                Console.WriteLine("Cozy & Warm!");
                
            } else
            {
                Console.WriteLine("It's {0} degrees Cº", temperature);
            }

            Console.Read();
        }*/

        /* My Solution
         * public static void loginSystem()
        {
            string username = "";
            string password = "";

            Console.WriteLine("Do you want to regist in our system?");
            bool toRegist = bool.Parse(Console.ReadLine());

            if (toRegist)
            {
                Console.WriteLine("Please define your username:");
                username = Console.ReadLine();
                Console.WriteLine("Please define your password:");
                password = Console.ReadLine();

                if(!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    Console.WriteLine("You are registered.");
                    Console.WriteLine("Let´s login in the system.");
                    Console.WriteLine("Please enter your username:");
                    string username1 = Console.ReadLine();
                    Console.WriteLine("Please enter your password:");
                    string password1 = Console.ReadLine();

                    if (username.Equals(username1) && password.Equals(password1))
                    {
                        Console.WriteLine("Welcome {0}", username);
                    } else
                    {
                        Console.WriteLine("Credentials are wrong.");
                    }

                } else
                {
                    Console.WriteLine("You have not defined a valid username or password.");
                }

            } else
            {
                Console.WriteLine("Thanks and welcome next time!");
            }
        }*/

        /*public static void Register()
        {
            Console.WriteLine("Please enter your username:");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed!");
            Console.WriteLine("-----------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username:");
            if (username == Console.ReadLine()){
                Console.WriteLine("Please enter your password:");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login sucessful");
                } else
                {
                    Console.WriteLine("Login failed, wrong password. Restart Program.");
                }
            } else
            {
                Console.WriteLine("Login failed, wrong password. Restart Program.");
            }
        }*/

        /*public static void checkAge()
        {
            Console.WriteLine("Insert your age:");
            age = int.Parse(Console.ReadLine());

            switch(age)
            {
                case 15:
                    Console.WriteLine("Too young to party in the club!");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }
        }*/

        /*public static void LeaderBoard()
       {
           Console.WriteLine("Please enter your score");
           int score = int.Parse(Console.ReadLine());
           if (score > highscore) {
               highscore = score;
               Console.WriteLine("Please enter your name:");
               highscorePlayer = Console.ReadLine();

               Console.WriteLine("New highscore is "+ highscore + "\nNew highscore holder is "+ highscorePlayer);
           } else
           {
               Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer);
           }
       } */

        /*public static void ExplicitImplicitConversion()
        {
            //explicit conversion
            double myDouble = 13.37;
            int myInt;
            
            
            //cast double to int;
            myInt = (int)myDouble;
            Console.WriteLine(myInt);


            //implicit conversion
            int num = 12390532;
            long bigNum = num;

            //typeConversion
            String myString = myDouble.ToString();


        }*/


        /*public static void Temperature()
        {
            Console.WriteLine("What is the temperature now?");
            string inputTemperature = Console.ReadLine();
            int currentTemperature;
            int number;

            if (int.TryParse(inputTemperature, out number))
            {
                currentTemperature = number;
            }
            else
            {
                Console.WriteLine("Not a valid temperature!");
                return;
            }

            string resultString = currentTemperature <= 15 ? "it is too cold here" : (currentTemperature >= 16 && currentTemperature <= 28) ? "it is ok" : currentTemperature > 28 ? "it is hot here" : "";
            Console.WriteLine(resultString);
            Console.Read();
        }*/
    }
}
