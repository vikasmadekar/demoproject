using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Foreachh
    {
        static void Main()
           {
            string[] car = { "bmw", "suzuki", "thar", "fournicher" };

           foreach (string i in car)
            {
                Console.WriteLine(i);   
            }
        }
    }
}
