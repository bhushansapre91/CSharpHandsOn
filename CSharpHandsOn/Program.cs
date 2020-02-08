using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn
{
    class Program
    {
        static void Main1()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            Console.WriteLine("Hello {0}", name);

           
            int[] a = new int[3];
            a[1] = 1;
            int[] b = {1, 5, 9 };

            for(int i=0; i<b.Length; i++)
            {
                Console.WriteLine(a[i]);
                Console.WriteLine(b[i]);
            }
            Console.ReadLine();
        }
    }
}
