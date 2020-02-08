using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn
{
    class MyConstructor
    {
        public MyConstructor()
        {
          //  Console.WriteLine("MyConstructor 0 argument constructor");
        }

        public MyConstructor(int a)
        {
            Console.WriteLine("MyConstructor 1 argument constructor");
        }

        public void Sum()
        {
            Console.WriteLine("Base Sum");
        }

        public void Multiplication()
        {
            Console.WriteLine("Base Multiplication");
        }
    }

    class MyTestClass : MyConstructor
    {
        MyTestClass()
        { 
           // Console.WriteLine("MyTestClass 1 argument constructor");
        }

        public new void Sum()
        {
           Console.WriteLine("Inherited Sum");
        }

        public void divide()
        {
            Console.WriteLine("Child Divide");
        }

        public static void MainMyConstructor()
        {
            Console.WriteLine("Inside Main");
            MyTestClass mtc = new MyTestClass();
            MyConstructor mc = new MyConstructor();
            MyConstructor mc1 = new MyTestClass();

            mtc.Sum();
            mc.Sum();
            mc1.Sum();

            //mc.divide(); //not allowed.
            //mc1.divide(); //not allowed even though mc1 points to the MyTestClass object.
            mtc.divide();

            Console.ReadLine();
            
        }
    }
}
