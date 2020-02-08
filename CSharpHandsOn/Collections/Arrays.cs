using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn.Collections
{
    class Arrays :IDisposable
    {
        
        public static void Main()
        {
            int[] myIntArray = new int[] {1, 2, 3, 4, 5};
            //If we specify the length of the array, then we need to provide = no. of elements during declaration. 
            //Else it throws error.
            // i.e. declaring new int[4] { 1, 2, 3, 4, 5, 6 }; will throw error.
            //similarly, new int[4] { 1, 2, 3} will also throw error.
            // new int[4] { 1, 2, 3, 4} will work fine because the array initialize matches the declared length of the array.
            int[] myIntArray3 = new int[5] { 1, 2, 3, 4, 5 }; 
                                                              
            int[] myIntArray1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] myIntArray2 = { 1, 2, 3, 4, 5, 6 };

           // int[] myIntArray4 = new int[4] { 1, 2, 3};

            for (int a = 0; a < myIntArray.Length; a++)
            {
                Console.WriteLine("Element at Index {0} position {1} in the array is {2}", a, a+1, myIntArray[a]);
               // Console.ReadKey();
            }

          
            
            Console.ReadLine();
        }

        public void Dispose()
        {

        }
    }
}
