using System;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //two dimensional array
            int[,] array2D = new int[,]
            {
                {1,2,3}, // row 0
                {4,5,6}, // row 1
                {7,8,9} // row 2
            };

            Console.WriteLine("central value is {0}", array2D[1, 1]);
            Console.WriteLine("Exersice {0}", array2D[2, 0]);

            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001" },
                    {"010", "011" }
                },
                {
                    {"100", "101" },
                    {"110", "111" }
                }
            };

            Console.WriteLine("Value is {0}", array3D[0,1,0]);

            string[,] array2DString = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };

            array2DString[1, 1] = "chicken";

            Console.WriteLine("value is {0}", array2DString[1,1]);

            var dimensions = array2DString.Rank;

            Console.WriteLine("Dimensions {0}", dimensions);

            int[,] array2D2 = { {1,2 }, {3,4 } }; 

            Console.ReadKey();
        }
    }
}
