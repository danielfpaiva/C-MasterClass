using System;
using System.Text.RegularExpressions;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;

            Console.WriteLine("grades at index 0: {0}", grades[0]);

            string input = Console.ReadLine();
            grades[0] = int.Parse(input);
            Console.WriteLine("grades at index 1: {0}", grades[0]);

            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            int[] gradesOfMathStudentsB = new int[] { 15, 20, 3, 17, 18, 15 };

            Console.WriteLine("Length of gradesOfMathStudentsA: {0}", gradesOfMathStudentsA.Length);

            int[] nums = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 10;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element {0} = {1}", j, nums[j]);
            }

            int counter = 0;
            foreach (int k in nums)
            {
                Console.WriteLine("Element {0} = {1}", counter, k);
                counter++;
            }

            string[] friends = new string[5] { "Pedro", "Daniel", "Tiago", "João", "Miguel" };

            foreach (string k in friends)
            {
                Console.WriteLine("Hi {0}", k);
            }

            Console.WriteLine("############################################");
            Console.WriteLine("Please insert your input value:");
            string input1 = Console.ReadLine();
            Console.WriteLine("What is the type of the inserted value?");
            Console.WriteLine("Press 1 for String \n Press 2 for Integer \n Press 3 for Boolean");
            int typeInput;
            bool valid;
            bool success = int.TryParse(Console.ReadLine(), out typeInput);

            if (success)
            {
                switch (typeInput)
                {
                    case 1:
                        if(Regex.IsMatch(input1, @"^[a-zA-Z]+$"))
                        {
                            Console.WriteLine("It is a valid: String");
                        } else
                        {
                            Console.WriteLine("It is an invalid: String");
                        }
                        return;
                    case 2:
                        int number;
                        valid = int.TryParse(input1, out number);
                        if (valid)
                        {
                            Console.WriteLine("It is a valid: Number");
                        } else
                        {
                            Console.WriteLine("It is an invalid: Number");
                        }
                        return;
                    case 3:
                        bool inputBool;
                        valid = bool.TryParse(input1, out inputBool);
                        if (valid)
                        {
                            Console.WriteLine("It is a valid: Boolean");
                        } else
                        {
                            Console.WriteLine("It is an invalid: Boolean");
                        }
                        return;
                    default:
                        Console.WriteLine("Invalid type");
                        return;
                }
            } else
            {
                Console.WriteLine("You should enter a valid number");
            }
            Console.ReadKey();
        }
    }
}
