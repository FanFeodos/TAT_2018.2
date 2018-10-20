using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_1._1
{
    class MyStack
    {
        int Capacity = 0; // max size of stack

        public int actualSize = 0; // current size of stack

        int[] elements; //elemets of stack

        public MyStack()
        {
            Capacity = 10; //default size

            elements = new int[Capacity];

        }

        void ReSize() //Resize of Stack 
        {
            int[] temp = new int[Capacity * 2]; //memory allocation
            for (int i = 0; i < Capacity - 1; i++) //transfer data to new location
                temp[i] = elements[i];
            Capacity *= 2;
            elements = temp;
        }
        public int pop() //extract last element
        {
            if (actualSize == 0)
                throw new Exception("stack is empty");
            else
            {
                int popElem = elements[actualSize-1];
                elements[actualSize-1] = 0;
                actualSize--;
                return popElem;
            }
        }

        public void push(int lastIn) //add element
        {
            if (Capacity - actualSize == 1)
            {
                ReSize();
            }
            elements[actualSize] = lastIn;
            actualSize++;
        }

        public int GetHead() //get head of Stack
        {
            if(actualSize == 0)
                throw new Exception("stack is empty");
            return elements[0]; 
        }
    }
}
