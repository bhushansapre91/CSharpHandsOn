using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn.Polymorphism
{
    class MyBaseClass
    {
        string FirstName = "Base FirstName";
        string LastName = "Base LastName";

        public virtual void PrintFullName()
        {
            Console.WriteLine($"Base FullName is {FirstName} {LastName}");
        }
    }

    class MyChildClass : MyBaseClass
    {
        string FirstName = "Child FirstName";
        string LastName = "Child LastName";

       public void PrintFullName()
        {
            Console.WriteLine($"Child FullName is {FirstName} {LastName}");
        }
    }
    class PolymorphismExample
    {
        public static void Main(string[] args)
        {
            MyBaseClass myBaseClass = new MyBaseClass();
            myBaseClass.PrintFullName();

            MyBaseClass myBase = new MyChildClass();
            myBase.PrintFullName();

            MyChildClass myChild = new MyChildClass();
            myChild.PrintFullName();

            Console.ReadLine();
        }
    }
}
