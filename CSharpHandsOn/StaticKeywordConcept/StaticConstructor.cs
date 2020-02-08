using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn.StaticKeywordConcept
{

    class MyStaticConstructor
    {
        static MyStaticConstructor()
        {
            Console.WriteLine("This is static constructor");
        }

        public MyStaticConstructor()
        {
            Console.WriteLine("This is normal constructor");
        }
    }
   public class StaticConstructor
    {
        public static void Main(string[] args)
        {
            //Static constructor will be called only once before the creation of the first object.
            MyStaticConstructor msc = new MyStaticConstructor();
            MyStaticConstructor msc1 = new MyStaticConstructor();

            Console.ReadKey();
        }
    }
}

//Output
//This is static constructor
//This is normal constructor
//This is normal constructor