using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{      class Constantt
    {
        public const string str = "madekarvikas";
        public string name = "Test";

        public void PrintConstants()
         {
            Console.WriteLine("The name str :{madekarvikas}");
            name = "Test1";
            Console.WriteLine(name);
          }

    }
    internal class Staticc
    {
        static void Main()
        {
            Constantt  con = new Constantt();
            con.PrintConstants();
        }
    }
}
