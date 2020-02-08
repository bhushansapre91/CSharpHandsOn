using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn
{
    abstract class AbstractKeyword
    {
        //abstract int b; // abstract modifier is not valid on fields.
        //public abstract int B { get; set; }
        public abstract void nonAbstractMethod();
        
    }

    class AbstractRunner : AbstractKeyword
    {
        //AbstractKeyword ak = new AbstractKeyword(); Cannot create object of the abstract class.
        public override void nonAbstractMethod()
        {
            
        }
    }
}
