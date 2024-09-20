using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Continues
    {
        static void Main()
        {
            int i;
            for (i=0;i<=10;i++)
            {
                if(i ==6)
                {
                    continue   ;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("LOOP END");

            
        }
        
    }

}
