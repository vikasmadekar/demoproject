using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Goto_sta
    {
        static void Main()
        {

            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);

                if (i == 9)
                {
                    continue;

                }
            }
        }
    }
}