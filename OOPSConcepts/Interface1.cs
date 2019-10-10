using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    interface Interface1
    {
        // public void Method1(); // this code gives error as interface members must not be specified public
        void Method1();
    }

    interface ISubject1
    {
        string GetNameById(int id);
    }
    interface ISubject2 : ISubject1
    {
        string GetNameByTitle(string title);
    }
    interface ISubject3
    {
        string GetNameById(int id);
    }
}
