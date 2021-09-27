using System;

namespace ParamsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //ParamsMethod("This", "is", "just", "a", "silly", "lesson");

            //ParamsMethod2(50,3.14f,'@',"The Hobbit");

            ParamsMin(5,8,3,8,9,5,-2);
        }

        public static int ParamsMin(params int[] numbers)
        {
            int min = int.MaxValue;

            foreach(int number in numbers)
            {
                min = Math.Min(number, min);
                Console.WriteLine("Now min is {0}", min);
            }

            return min;
        }

        public static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i< sentence.Length; i++)
            {
                Console.WriteLine(sentence[i] + "  ");
            }
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            foreach (object obj in stuff)
            {
                Console.WriteLine(obj + "  ");
            }
            Console.WriteLine();
        }
    }
}
