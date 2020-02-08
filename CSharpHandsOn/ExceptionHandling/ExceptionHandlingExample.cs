using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn.ExceptionHandling
{
    class ExceptionHandlingExample
    {
        public static void Main(string[] args)
        {
            int zero = 0;
            try
            {
                int i = 1 / zero;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Information: " + e.Message);
                Console.WriteLine("Catch Block");
            }
            catch(ArithmeticException ae)
            {

            }
        }
    }
}
