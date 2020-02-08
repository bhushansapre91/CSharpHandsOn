using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpHandsOn.ExtensionMethods;

namespace CSharpHandsOn.Collections
{
    
    public class DictionaryProgram
    {
        
        public static void Main(string[] args)
        {
           

            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            myDictionary.Add(1, "One");
            myDictionary.Add(2, "Two");
            myDictionary.Add(3, "Three");

          

            Dictionary<int, string>.KeyCollection keyCollection =  myDictionary.Keys;
            Dictionary<int, string>.ValueCollection valueCollection = myDictionary.Values;
            DictionaryProgram dc = new DictionaryProgram();
            dc.myExtensionMethod();

            var myLINQ = from myDictionary1 in myDictionary
                         where myDictionary1.Key < 3
                         select myDictionary1;

            foreach(var i in myLINQ)
            {
                Console.WriteLine("\nLINQ:\n"+i.Key +" : "+i.Value);
            }

            var LINQMethod = myDictionary.Select(x => x);
            foreach (var i in LINQMethod)
            {
                Console.WriteLine("\nLINQ:\n" + i.Key + " : " + i.Value);
            }


            Console.ReadLine();
        }


        public string myInt()
        {
            return "Name" ?? throw new ArithmeticException("Rithmetic Exception");
        }

    }
}
