using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List <int>{ 100, 102, 104, 106,  108, 110, 112, 114, 116, 118, 120, 122, 124, 126, 128, 130,
            132,134,136,138,140,142,144,146,148,150,152,154,156,158,160,162,164,166,168,170};

            List<int> list1 = WithoutChangeOriginalList(myList);

        }

        private static List<int> WithoutChangeOriginalList(List<int> originalList)
        {
            //without change myList
            List<int> evenNumbers = new List<int>();

            foreach (int number in originalList)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }

            }

            return evenNumbers;
        }

        private static List<int> ChangeOriginalList(List<int> originalList)
        {
            foreach (int number in originalList)
            {
                if (number % 2 == 0)
                {
                    originalList.Remove(number);
                }

            }
            return originalList;
        }
    }
}
