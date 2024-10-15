using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    public static  class My_static
    {
        public static void Sub(this Extension_method em,int d,int e ,int f )
        {
            f = d - e;
            Console.WriteLine("The parameter is subtraction   :"+f);
        }
        public static void Mul(this Extension_method em ,int g,int h,int j )
        {
            j=g*h;
            Console.WriteLine("The parameter is  Multiplication :"+j);

        }
        public static void Div(this Extension_method  em ,int m,int l,int v)
        {
            v=m/l;  
            Console.WriteLine("The parameter is   division  :"+v);

        }
    }
}
