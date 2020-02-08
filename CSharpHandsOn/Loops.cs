using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn
{
    class Loops
    {
       
        static double MainLoops(String[] args)
        {
            int num = 0;
            Console.WriteLine("Enter a number of your choice");
            //int userNum = int.Parse(Console.ReadLine());
            int userNum = 10;
            do
            {
                Console.Write(num +" ");
                //num = num + 2;
                num += 2;
            } while (num<=userNum);
            Console.ReadLine();

            return 3.14;
        }
        void sum()
        {
            int choice = 0;
            if(choice == 1)
            {
                Console.WriteLine("1==1");
            }
            else if(choice == 2)
            {
                Console.WriteLine("1==2");
            }
            else
            {
                Console.WriteLine("Something Else");
            }
        }

        /*
        // overloaded Main() Method 
        static void Main(int n)
        {
            Console.WriteLine("Overloaded Main Method");
        }

        // overloaded Main() Method 
        static void Main(int x, int y)
        {
            Console.WriteLine("Overloaded Main Method");
        }
        */
    }

    class MyClass : Loops
    {
        MyClass()
        {

        }
    }
}
