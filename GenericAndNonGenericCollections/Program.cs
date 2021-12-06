using System;
using System.Collections;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // delcaring an ArrayList with undefined of objects
            ArrayList myArrayList = new ArrayList();
            // delcaring an ArrayList with defined of objects
            ArrayList myArrayList2 = new ArrayList(200);

            myArrayList.Add(25);
            myArrayList.Add("hello");
            myArrayList.Add(2.53);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);

            // delete element with specific value from array list
            myArrayList.Remove(13);

            // delete element at specific point
            myArrayList.RemoveAt(4);

            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach (object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double @double)
                {
                    sum += @double;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
