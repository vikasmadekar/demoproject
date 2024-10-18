using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    
    
    
   public  class Ref_Example
    {
        static void incrementvalueNum(ref int M)
        {
            M++;
        }


        static void Main()
        {
            int V  = 10;
            Console.WriteLine($"Befour incrementvalue of v is :-{V}");
            incrementvalueNum(ref V);
            Console.WriteLine($"After incrementvale of v  is :{V}");

        }


    }
}
