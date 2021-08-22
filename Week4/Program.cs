using System;

namespace Week4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i;
            }

            Swap(myArray, 4, 5);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }

        public static void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}
