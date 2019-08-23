using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    class TryCatchConcepts
    {
        public void TryCatchMethod()
        {
            try
            {
                try
                {
                    try
                    {
                        throw new Exception("Exception from inner try");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("inner catch block: " + ex.Message);
                        throw ex;
                    }
                    finally
                    {
                        Console.WriteLine("Finally of inner try catch block");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("middle catch block: " + ex.Message);
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("outer catch block: " + ex.Message);
            }

        }
    }
}
