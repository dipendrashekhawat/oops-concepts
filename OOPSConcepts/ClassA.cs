using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    class ClassA
    {
        // some implementations
    }

    class B : ClassA, Interface1, Interface2
    {
       /* public void Interface1.Method1() // interface methods should not be preceeded with public keyword
        {
            //some code for method1 of interface1;
        }
       */

        void Interface1.Method1() // interface methods should not be preceeded with public keyword
        {
            //some code for method1 of interface1;
        }

        void Interface2.Method1() // interface methods should not be preceeded with public keyword
        {
            //some code for method1 of interface2;
        }
    }
}
