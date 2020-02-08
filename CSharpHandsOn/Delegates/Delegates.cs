using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn.Delegates
{
    class Delegates
    {
        public static void Main(string[] args)
        {
            //Calling the same MainMethod() while passing 2 different functions with similar signature using Action<> delegate
            MainMethod(Method1);
            MainMethod(Method2);

            Console.ReadLine();
        }

        public static void Method1(string number)
        {
            Console.WriteLine("Function Method 1"); ;
        }

        public static void Method2(string number)
        {
            Console.WriteLine("Function Method 2"); ;
        }

        public static void MainMethod(Action<string> MyAction)
        {
            MyAction("Some Value");
        }
    }
}
