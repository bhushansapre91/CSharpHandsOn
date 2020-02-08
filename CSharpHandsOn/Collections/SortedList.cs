using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn.Collections
{
    class SortedList
    {
        public static void Main(string[] args)
        {
            SortedList<int, string> mySortedList = new SortedList<int, string>();

            mySortedList.Add(1, "One");
            mySortedList.Add(2, "Two");
            mySortedList.Add(3, "Three");
            mySortedList.Add(4, "Four");

            foreach(var i in mySortedList)
            {
                Console.WriteLine(i.Key + ":" + i.Value);
            }

            mySortedList.Remove(3);
            foreach (var i in mySortedList)
            {
                Console.WriteLine(i.Key + ":" + i.Value);
            }


            Console.ReadLine();
        }
    }
}
