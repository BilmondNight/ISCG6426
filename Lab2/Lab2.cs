/// This is the Lab 2 of ISCG6426
/// Provided by Handeng Zhou (Joel)
/// Student ID: 1521094

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public class Node
    {
        public int data;
        public Node link;
    }

    public class Head
    {
        public int count;
        public int max;
        public Node top;

        public Head()
        {
            count = 0;
            max = 0;
        }

        public Head(int max)
        {
            this.max = max;
        }

        public void Push(int value)
        {
            // check if space is available
            if (count < max)
            {
                Node newNode = new Node(); // create a new node

                newNode.data = value; // set node value to param value

                newNode.link = top; // add node to stack

                top = newNode; // update top

                ++count; // increment count
            }
        }

        public int Pop()
        {
            // check if value exist
            if (count > 0)
            {
                Node temp = top; // select the top of the stack

                top = top.link; // remove the top from the stack

                count--; // decrement count

                return temp.data; // return the value
            }
            return -1;
        }

        public bool EmptyStack()
        {
            if (count < 1) return true; // return empty

            else return false; // return not empty
        }

        public void Clear()
        {
            while (count > 0) Pop();  // remove all values
        }

        static void Main(string[] args)
        {
            Head test = new Head(10); // new object, set Max = 10

            Console.WriteLine(test.EmptyStack()); // is empty

            // push 10 values
            int[] myArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                myArray[i] = new Random().Next(1, 1000);
                test.Push(myArray[i]);
            }
                
            // pop 5 values
            int[] myPop = new int[5];
            for (int i = 0; i < 5; i++)
            {
                myPop[i] = test.Pop();
                Console.WriteLine(myPop[i] + " is popped");
            }

            // print sum and average of popped values
            double sum = 0;
            for (int i = 0; i < myPop.Length; i++)
            {
                sum += myPop[i];
            }
            double average = sum / myPop.Length;
            Console.WriteLine("The sum of popped values is {0} and the average is {1}", sum, average);
            
            Console.WriteLine(test.EmptyStack()); // is not empty
            test.Clear(); // remove all values
            Console.WriteLine(test.EmptyStack()); // is empty
        }
    }
}
