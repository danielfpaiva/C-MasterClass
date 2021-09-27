using System;

namespace ArraysAsParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] studentsGrades = new int[] { 15, 13, 8, 9, 10, 20, 21 };

            //foreach(int grades in studentsGrades){
            //    Console.WriteLine("{0}", grades);
            //}


            //Console.WriteLine("The Average is {0}", GetAverage(studentsGrades));

            int[] happiness = new int[] { 1, 3, 5, 2, 3 };
            SunIsShining(happiness);

        }

        static void SunIsShining(int[] happinessArray)
        {
            foreach(int happiness in happinessArray){

                Console.WriteLine("New happiness: {0}", (happiness+2) );

            }
            Console.ReadKey();
        }

        static double GetAverage(int [] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i<size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
        }
    }
}
