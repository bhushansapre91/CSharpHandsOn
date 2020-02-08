using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn
{
    public class ArrayListClass : Object
    {
        ArrayList myList = new ArrayList();
        // Adding elements to ArrayList 

        public ArrayListClass()
        {
            Console.WriteLine("Capacity :"+myList.Capacity);
            myList.Add("A");
            myList.Add('B');
            myList.Add(1);
            myList.Add(DateTime.Parse("7-7-2019"));
            Console.WriteLine("Capacity :" + myList.Capacity);
            myList.Add("1");
            Console.WriteLine("Capacity :" + myList.Capacity);
            myList.Add("A");
            myList.Add('B');
            myList.Add(1);
            myList.Add("1");
            Console.WriteLine("Capacity :" + myList.Capacity);
            Console.WriteLine("================={0}===================", myList.Count);
            myList.Insert(5, 12345);

            foreach (var obj in myList)
            {
                Console.WriteLine("{0} : {1}", obj.GetType(), obj);
            }
            Console.WriteLine("================={0}===================", myList.Count);
            myList.Clear();
            Console.WriteLine("Capacity :" + myList.Capacity);

            List<int> intList = new List<int>();
            intList.Add(5);

        }

        public static void Main(string[] args)
        {
            ArrayListClass collection = new ArrayListClass();
            Console.ReadLine();
        }
    }
}