using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Outparameter_example
    {
        static void Main()
        {
            int a;
            string str;
           
            InitializeValue(out  int num,out string text);

            Console.WriteLine($"Number :{num}");
            Console.WriteLine($"String : {text}");

           static void  InitializeValue(out  int num,out string text)
            {
                num = 34;
                text = "VIKAS MADEKAR";
            }



        }

    }
}
