using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Arr
    {
        static void Main()
        {
            // Array declare
            string[] Mobile = new string[4];
            Mobile[0] = "vivo";
            Mobile[1] = "opp";
            Mobile[2] = "apple";
            Mobile[3] = "pro";

            for(int i=0;i<Mobile.Length;i++)
            {
                Console.WriteLine (Mobile[i]);
            }


            
        }   
    }
}
