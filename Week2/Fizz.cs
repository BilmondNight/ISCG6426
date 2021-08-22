using System;
using System.Collections.Generic;
using System.Text;

namespace Week2
{
    public class Fizz
    {
        public static void fizz()
        {
            Console.WriteLine("Please enter a number: ");
            String input = Console.ReadLine();
            Console.WriteLine("Your input is: " + input);
            
            int temp = int.Parse(input);
            for (int i = 1; i <= temp; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i + " is FizzBuss");
                    }
                    else
                    {
                        Console.WriteLine(i + " is Fizz");
                    }
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " is Buss");
                }
                else { Console.WriteLine(i); }
            }
        }
    }
}
