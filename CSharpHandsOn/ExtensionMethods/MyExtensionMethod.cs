using CSharpHandsOn.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn.ExtensionMethods
{
    public static class MyExtensionMethod
    {
        public static void myExtensionMethod(this DictionaryProgram dp)
        {
            Console.WriteLine("This is an extension Method");
        }
    }
}
