using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    class Staticpolymorphism
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

    internal class Calculator
    {
        static void Main()
        {
            Staticpolymorphism sta = new Staticpolymorphism();

            int sub1 = sta.Sub(4, 1);
            float sub2 = sta.Sub(55.5F, 36.5F);

            Console.WriteLine("the subtraction is:" + sub1);
            Console.WriteLine("the subtraction is:" + sub2);
        }
    }
}


