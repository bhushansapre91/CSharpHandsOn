using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn.DataTypes
{
    class DataTypes
    {
        
        

        public static void Main()
        {
            int a = 10;
            float b = 10.33f;

            float c = a;
            //int d = b; //Cannot implicitely convert a float to int. Must be done via casting.
            int d1 = (int)b;
            //or
            int d2 = Convert.ToInt32(b);

            //char
            char ch = 'c';
            Console.Write(ch);

            Console.ReadLine();
        }
    }
}
