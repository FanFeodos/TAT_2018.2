using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyStack Igor = new MyStack(); //create an exemplar of class "MyStack"
                int pushElem = 117;
                Igor.push(pushElem); //push elelments in stack
                for (int i = 0; i <= 10; i++)
                    Igor.push(i);  //testing function of resize
                Console.WriteLine($"Head of Stack: {Igor.GetHead()}"); //get a Head of stack
                int numberOfPopElements = 15;
                int[] popElements = new int[numberOfPopElements];
                for (int i = 0; i <= numberOfPopElements; i++) //testing execption
                    popElements[i] = Igor.pop();
            }
            catch  (Exception)
            {
                Console.WriteLine("Stack is empty"); //catch an Exception
            }
            Console.ReadKey();
        }
    }
}
