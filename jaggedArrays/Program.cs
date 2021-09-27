using System;

namespace jaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //              index         0   1  2
            // normal array of type int: [5][10][55]
            //               index                  0                           1                       2 
            // jagged array of type int: [array1([10],[11],[12])],[array1([20],[21],[22])],[array1([30],[31],[32])]

            // declare Jagged Array
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 1, 2, 3, 4, 5 };
            jaggedArray[1] = new int[] { 7, 8, 9 };
            jaggedArray[2] = new int[] { 20, 21 };

            // alternative way:

            int[][] jaggedArray2 = new int[][]
            {
                new int[] {5,8,9,10},
                new int[] {55,66}
            };

            Console.WriteLine("The value in the middle of first entry is {0}", jaggedArray2[0][2]);

            for (int i = 0; i<jaggedArray2.Length;i++)
            {
                Console.WriteLine("Element {0}", i);
                for (int j = 0; j<jaggedArray2[i].Length;j++)
                {
                    Console.WriteLine("Element of array {0} in position {1} is {2}", i,j,jaggedArray2[i][j]);
                }
            }

            Console.ReadKey();
        }
    }
}
