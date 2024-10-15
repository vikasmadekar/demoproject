using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Call_extension
    {

        static void Main()
        {

            Extension_method e= new Extension_method();
            e.Sub(20,10,0);
            e.Mul(20, 10, 0);
            e.Div(10, 5, 0);
            e.Addition (40,40,0);
        
         

        }
    }
}
