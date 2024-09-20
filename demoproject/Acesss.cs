using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{      
     class Abc
     {
       public  int a=10;
        public int b=20;
        public c=a+b;

        void Addition()
        {
            Console.WriteLine("addtion is "+c);
        }
     }
    class Acesss
    {   

        static void Main()
        {

         Abc obj= new Abc();
         obj.Addition();
        }
    }
}
