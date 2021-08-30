using System;
using System.Collections.Generic;
using System.Text;

namespace Week5
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
            // todo
            return true;
        }

        public void Clear()
        {
            // remove all values
        }

        public void Test()
        {
            // push 10 times
            // for.... push(rand.Next(1, 1000));

            // pop 5 times
            // int[] popped = new int[5];
            // for.... popped[i] = Pop();

            // calcute average of popped values
            // print average
            // cw....

            // calculate sum of popped values
            // print sum
            // cw....
        }
    }
}
