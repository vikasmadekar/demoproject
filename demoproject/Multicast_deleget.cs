using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{

    public delegate void Alldeleget(int a ,int b);


    class Mul
    {
        public void  Addition(int a,int b)
        {
           Console .WriteLine (a + b);
        }
         

        public void subtraction(int a,int b)
        {
            Console.WriteLine(a - b);
                

            
        }
        public void multiplication(int a,int b)
        {
            Console.WriteLine(a * b);
        }
    }
    internal class Multicast_deleget
    {
        static void Main()
        {
            Mul mul = new Mul();


            Alldeleget a=new Alldeleget (mul.Addition);
            a += mul.subtraction; 
            a += mul.multiplication;
            a(20, 25);

        }
    }
}
