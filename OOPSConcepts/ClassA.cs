
namespace OOPSConcepts
{
    class ClassA
    {
        // some implementations
    }


    class B : ClassA, Interface1, Interface2 // Class should always be preffered over interfaces
    {
        /* public void Interface1.Method1() // interface methods should not be preceeded with public keyword
         {
             //some code for method1 of interface1;
         }
        
         override void Interface1.Method1() // interface methods cannot be preceeded with 
                                           // override keyword: override keyword is not valid for  this item.
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

    // Abstract class / method Example
    // Abstract classes are those which cannot be instantiated.
    // Abstract classes allow you to provide default functionality for the subclasses.
    // The purpose of an abstract class is to define some common behavior that can be inherited by multiple subclasses

    abstract class D
    {
        public void NonAbstractMethod() // abstract class will also work only with a Non Abstract method without any abstract method.
        {
            // some logic
        }

        public abstract void AbstractMethod(); // only method declaration is allowed without implementation.
    }

    class E : D
    {
        public override void AbstractMethod() // you need to override the abstract method in the derived class
        {
            // business logic; 
            // if you donot implement it gives Error =>	'OOPSConcepts.E' does not implement inherited abstract member 'OOPSConcepts.D.AbstractMethod()'
        }
    }
}
