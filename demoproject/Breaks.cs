using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Breaks
    {
        static void Main()
        {
            int a;
            for(a=1;a<10;a++)

            {
                if (a==6)
                {
                    break ;
                }
                Console.WriteLine(a);   
            }
            Console.WriteLine("loop end");
        }

    }
}
