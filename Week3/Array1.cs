using System;
using System.Collections.Generic;
using System.Text;

namespace Week3
{
    class Array1
    {
        public static void myArray()
        {
            Random ran = new Random();
            int[] intArray = new int[100];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = ran.Next(0, 20);
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] == 17)
                {
                    Console.WriteLine($"Found 17 at index {i}");
                }
            }
        }
    }
}
