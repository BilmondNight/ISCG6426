using System;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[20];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i;
            }

            int result = Search.BinaryRecursive(myArray, 12, 0, myArray.Length - 1);
            Console.WriteLine(result);
        }
    }
}
