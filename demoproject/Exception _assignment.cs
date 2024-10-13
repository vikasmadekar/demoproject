using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Exception__assignment
    {
        static void Main()
        {
            int a = 15;
            int b = 0;
            int c;

            try
            {
                c = a / b;     
                  Console.WriteLine(c);

            }
            catch(DivideByZeroException ex )
            {
               Console .WriteLine  ("division is not");
                Console.WriteLine(ex.Message);
                
            }
            try
            {
                string s = "vikas1234";
                int result = int.Parse(s);
            }
            catch (FormatException ex)
            {
                Console .WriteLine (ex .Message);

            }
            try
            {
                int Max = int.MaxValue;
                int result = checked(Max + 1);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
