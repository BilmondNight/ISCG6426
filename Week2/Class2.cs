using System;
using System.Collections.Generic;
using System.Text;

namespace Week2
{
    public class Class2
    {
        public void myMethod()
        {
            Random ran = new Random();

            int[] intArray = new int[1000];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i;
            }

            double[] dbArray = new double[100];
            for (int i = 0; i < dbArray.Length; i++)
            {
                dbArray[i] = ran.NextDouble() * 90 + 10;
                Console.WriteLine(dbArray[i]); 
            } 
        }
    }
}
