using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Binary
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            Console.WriteLine(ArrayBinarySearch(array, 13));
        }

        public static int ArrayBinarySearch(int[] array, int value)
        {
            int min = 0;
            int max = array.Length - 1;
            int counter = 0;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (value == array[mid])
                {
                    Console.WriteLine(counter + 1);
                    return mid;
                }
                else if (value < array[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
                counter++;
            }
            return -1;
        }
    }
}
