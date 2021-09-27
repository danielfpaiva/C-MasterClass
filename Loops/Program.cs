using System;

namespace Loops
{
    class Program
    {

        /*public static void ForLoop()
        {
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter + " is lower than 10.");
            }
            Console.Read();
        }*/

        /*public static void DoWhileLoop()
        {
            //int counter = 0;
            int lenghtOfText= 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please enter the name of a friend");
                string nameOfFriend = Console.ReadLine();
                int currentLenght = nameOfFriend.Length;
                lenghtOfText += currentLenght;
                wholeText += nameOfFriend;

                //Console.WriteLine(counter);
                //counter++;
                //} while (counter < 15);
            } while (lenghtOfText < 20);
            Console.WriteLine("Thanks that was enough! " + wholeText);
            Console.Read();

        }*/

        /*public static void WhileLoop()
        {
            int counter = 0;
            string enteredText = "";
            while (enteredText.Equals(""))
            {
                Console.WriteLine("Please press enter to increase amount by one adn anything else" + " + enter if you want to finish counting");
                enteredText = Console.ReadLine();
                
                counter++;
                Console.WriteLine("Current people count is {0}", counter);
            }
            Console.WriteLine("{0} people are inside the bus. Please enter to close the program!", counter);
            Console.ReadLine();
        }*/

        /*public static void BreakFun()
        {
            for (int counter = 0; counter<10; counter++)
            {
                Console.WriteLine(counter);
                if (counter == 3)
                {
                    Console.WriteLine("At 3 we stop!");
                    break;
                }
            }
            Console.Read();
        }*/
        /* public static void Continue()
        {
            for (int counter = 0; counter < 10; counter++)
            {
               
                if (counter == 3)
                {
                    Console.WriteLine("We skip number 3!");
                    continue;
                }
                Console.WriteLine(counter);
            }
            Console.Read();
        } */

        public static void Average()
        {
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while(input != "-1")
            {
                Console.WriteLine("Last number was {0}",input);
                Console.WriteLine("Enter the next score");
                Console.WriteLine("Current amount of entries {0}", count);
                Console.WriteLine("Please enter -1 when you are ready to calculate the average");

                input = Console.ReadLine();
                if (input.Equals("-1"))
                {
                    Console.WriteLine("--------------------------------------");
                    // calculate the average and show to teacher
                    double average = (double)total / (double)count;
                    Console.WriteLine("The average score is {0}",average);
                }
                if (int.TryParse(input, out currentNumber) && currentNumber>0 && currentNumber <= 20)
                {
                    total += currentNumber;
                } else
                {
                    if (!(input.Equals("-1")))
                    {
                        Console.WriteLine("Please enter a number between 0 and 20");
                    }
                    continue;
                }
                count++;

            }

            Console.Read();


        }

        static void Main(string[] args)
        {
            //ForLoop();
            //DoWhileLoop();
            //WhileLoop();
            //BreakFun();
            //Continue();
            Average();
        }

       
    }
}
