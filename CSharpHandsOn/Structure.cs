using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn
{
    public interface structInterface
    {
        void interfaceMethod();
    }

    struct myStruct1
    {
        public int a;
        private int b;
        int c;
        public void interfaceMethod() { }
    }

    struct myStruct2
    {
        int b;
    }

    class Structure
    {
        struct myStruct
        {
            int i1;
        }

        public void myStructMethod()
        {

        }
    }

  
    
}
