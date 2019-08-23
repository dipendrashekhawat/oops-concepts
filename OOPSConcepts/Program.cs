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
            var tryCatch = new TryCatchConcepts();
            tryCatch.TryCatchMethod();

            Console.ReadLine();
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