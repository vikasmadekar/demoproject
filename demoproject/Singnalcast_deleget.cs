using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{

    public delegate void Additiondelegate(int a,int b); //deleget declare 
    public delegate void Subtractiondelegate(int a,int b);

    class Vm  // class
    {
        public void Add(int a,int b)  // method 
        {
            Console.WriteLine(a+b);
        }
        public void Sub(int a,int b)
        {
            Console.WriteLine(a-b);
        }
    }
 class Singnalcast_deleget  // main class
    {
        static void Main()
        {
            Vm v = new Vm();  //  class chaya object create kela
            Additiondelegate a = new Additiondelegate(v.Add); // deleget mdhe main class chaya 
                                                                             //object pass kela
            v.Add(30,20);
            v.Sub(40, 20);
                
        }
    }
    
}
