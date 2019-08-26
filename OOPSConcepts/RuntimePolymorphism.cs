using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    class RuntimePolymorphism
    {
        public virtual void RuntimeMethod()
        { 
            // implementation
            Console.WriteLine("Runtime Base Class");
        }
    }

    class DerivedClass : RuntimePolymorphism
    {
        public override void RuntimeMethod()
        { 
            // override implementation of the parent class method
            Console.WriteLine("Runtime Derived Class");
        }
    
    }
}
