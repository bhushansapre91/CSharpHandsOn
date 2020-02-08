using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn
{
    class AnonymousMethods
    {
        delegate void PrintDelegate(string message);
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter input string:");
            string input = Console.ReadLine();

            PrintDelegate PD = delegate (string IMynput)
            {
                Console.WriteLine($"Message: {IMynput}");
            };

            PD(input);

            PD = myMethod;
            PD("Function");

            PD = x => Console.WriteLine("Lambda: "+ x);
            PD("Lambda");

            Func<string, string, string, int, int> funcExample;
            Action<int, int, string, string, double> actionExample;

            Console.ReadKey();
        }

        public static void myMethod(string myMessge)
        {
            Console.WriteLine("This is normal function: {0}", myMessge);
        }

        public static void myMethod1(string myMessge, int i)
        {
            Console.WriteLine("This is normal function: {0}", myMessge);
        }
    }
}
