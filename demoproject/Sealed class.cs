using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject


    
{

   class  Sealed1 
    {
       public void Sohw()
        {
            int m=40; int b=20;
            int z = m + b;
            Console.WriteLine(z);
        }
     
    }
    sealed class  Madekar : Sealed1
    {
           
          public void Display()
        {

            int a = 40; int e = 20;
            int v = a - e;
            Console.WriteLine(e);
        }

    }
    
    internal class Sealed_class
    {

        static void Main()
        {
            Madekar m=new Madekar ();
            m.Display();
            m.Sohw();
        }
    }
}
