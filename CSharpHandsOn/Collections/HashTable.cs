using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn.Collections
{
    class HashTableClass
    {
        public static void Main()
        {
            Hashtable ht = new Hashtable();

            ht.Add(1, "First");
            ht.Add("Second", 2);
            ht.Add('K', "Value");

            foreach(object obj in ht.Keys)
            {
                Console.WriteLine("Keys "+ obj);
            }
            Console.WriteLine("===========================================");
            foreach (object obj in ht.Values)
            {
                Console.WriteLine("Values " + obj);
            }
            Console.WriteLine("===========================================");
            foreach (DictionaryEntry obj in ht)
            {
                Console.WriteLine("Keys: {0} :: Values: {1}", obj.Key, obj.Value);
            }

            Console.ReadLine();
        }
    }
}
