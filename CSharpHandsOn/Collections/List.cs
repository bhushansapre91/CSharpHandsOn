using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn.Collections
{
    public class List
    {
        public static void Main(string[] args)
        {
            List<int> iList = new List<int>();

            iList.Add(111);
            iList.Add(123);
            iList.Add(456);
            
            Console.WriteLine("Values greater than 300: "+ iList.Count(x => x > 300));         
            Console.ReadLine();
        }
          
    }
}
