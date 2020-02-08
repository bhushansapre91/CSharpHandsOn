using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn.Collections
{
    class QueuePrgram
    {
        public static void Main()
        {
            Queue<string> myQueue = new Queue<string>();
            Console.WriteLine("Count: " + myQueue.Count);

            myQueue.Enqueue("MyQ1");
            myQueue.Enqueue("MyQ2");
            myQueue.Enqueue("MyQ3");
            Console.WriteLine("Count: " + myQueue.Count);

            Console.WriteLine("Element Present: ");
            bool isPresent = myQueue.Contains("1");
            Console.WriteLine(isPresent);

            
           
            Console.WriteLine("Peek in the Queue: " + myQueue.Peek() +"\n");

            Queue<string> myQueue2 = new Queue<string>(myQueue.ToArray());

            foreach(string s in myQueue2)
            {
                Console.WriteLine("Elements of Queue 2: "+s);
            }
           
            myQueue.Clear();

            Console.ReadKey();
        }
    }
}
