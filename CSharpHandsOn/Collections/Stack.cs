using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn.Collections
{
    class StackProgram
    {
        public static void Main(string[] args)
        {

            Stack<int> myStack = new Stack<int>();

            //Inserts the object at the top of the stack.
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);

            foreach(object obj in myStack)
            {
                Console.WriteLine("Item: "+ obj);
            }

            Console.WriteLine("Count: {0}", myStack.Count);
            Console.WriteLine("Peek: {0}", myStack.Peek());

            Console.WriteLine("Removing the top most element.");
            myStack.Pop();
            foreach (object obj in myStack)
            {
                Console.WriteLine("Item: " + obj);
            }

            Console.WriteLine("Removing all elements.");

           myStack.Clear();
            foreach (object obj in myStack)
            {
                Console.WriteLine("Item: " + obj);
            }

            Console.ReadLine();

        }
    }
}
