using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn.Inheritance
{
    class InheritanceExample : MySuperclass
    {
        public InheritanceExample() : this("Argument for 1 constructor")
        {
            Console.WriteLine("Subclass 0 parameter constructor.");
        }

        public InheritanceExample(string message)
        {
            Console.WriteLine("Subclass 1 parameter constructor.");
        }

        public static void Main()
        {
            InheritanceExample ie = new InheritanceExample();

            Console.ReadKey();
        }
    }

    public class MySuperclass
    {
        public MySuperclass()
        {
            Console.WriteLine("Super class 0 parameter constructor.");
        }

        public MySuperclass(string message)
        {
            Console.WriteLine("Super class 1 parameter constructor.");
            Console.WriteLine(message);
        }
    }

}
