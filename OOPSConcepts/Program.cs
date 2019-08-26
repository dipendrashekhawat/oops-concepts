using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            // try catch
            var tryCatch = new TryCatchConcepts();
            tryCatch.TryCatchMethod();

            // Runtime Polymorphism
            Polymorphic(true);

            Console.ReadLine();
        }

        private static void Polymorphic(bool flag)
        {
            RuntimePolymorphism rp;

            if (flag)
                rp = new DerivedClass();
            else
                rp = new RuntimePolymorphism();

            rp.RuntimeMethod(); // compiler doesnt know which method to call, it will be decided at runtime
        }

    }
}

// OUTPUT
/*
inner catch block: Exception from inner try
Finally of inner try catch block
middle catch block: Exception from inner try
outer catch block: Exception from inner try
*/