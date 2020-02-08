using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn.Strings
{
    class stringsInCSharp
    {
        public static void Main(string[] args)
        {
            string myString;         
            myString = "someValue";
          
            Console.WriteLine("String: "+myString);

            char[] myCharArray = {'A', 'B', 'C' };
            myString = new string(myCharArray);

            Console.WriteLine(@"""String is: ""{0}", myString);           

            //String Interpolation
            Console.WriteLine($"String interpolation: {myString}");

            //Substring
            myString = "This is some random string";
            string mySubstring = myString.Substring(3, 9);
            Console.WriteLine($"String interpolation: {mySubstring}");

            //Converting the string to lowercase
            string loweString = myString.ToLower();

            //Reversing the string by using Array notation with index value.
            for(int i = 0; i<myString.Length; i++)
            {
                Console.Write(myString[myString.Length - 1 - i]);
            }

            //IndexOf
            string indextOfString = "My index string";
            Console.WriteLine("Index of index is: ", indextOfString.IndexOf("index"));

            /* StringBuilder*/
            string sbString = "This is stringBuilder";
            StringBuilder sb = new StringBuilder(sbString);

            string constructorString = new string(new char[] {'1', 'A', '3' });

            try
            {

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                
            }

            Console.ReadLine();


        }
    }
}
