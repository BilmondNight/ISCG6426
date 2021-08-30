using System;

namespace Week5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] my = { 1, 2, 5, 6, 9 };
            int total = 0;
            foreach (int i in my)
            {
                if (i % 3 == 0)
                {
                    total += i;
                }
            }
            Console.WriteLine(total);
        }
    }
}
