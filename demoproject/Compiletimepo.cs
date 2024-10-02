using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
     internal class VIKAS
    {    
        class polymorphism
        {
            public int Sub(int a, int b)
            {
                return a - b;

            }
            
            public float Sub(float a, float b)
            {
                return a - b;
            }
        
        }


         
        static void Main()
        {

            polymorphism poil= new polymorphism();

            int sub = poil.Sub(5, 3);
            float  sub1=poil.Sub(555, 3);


            Console.WriteLine("sub of integrs:" + sub);
            Console.WriteLine("sub of float:" + sub);

        }


    }
}
