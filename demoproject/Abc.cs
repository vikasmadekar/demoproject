using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Ab
    {
        static void Main()
        {
            string str = "madekar";
            Console.WriteLine(str);
            int a = 10;
            int b = 20;
            int c;

            int ch;
            do
            {
               

                Console.WriteLine("Menu");
                Console.WriteLine("1.addition");
                Console.WriteLine("2.subtraction");
                Console.WriteLine("3.multiplication");
                Console.WriteLine("4.division");

                Console.WriteLine("enter the number");

                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        c = a + b;
                        Console.WriteLine("1. addition=" + c);
                        break;
                    case 2:
                        c = a - b;
                        Console.WriteLine("2.subtraction=" + c);
                        break;
                    case 3:
                        c = a * b;
                        Console.WriteLine("3.multiplication=" + c);
                        break;
                    case 4:
                        c = a / b;
                        Console.WriteLine("4.division=" + c);
                        break;



                }


            } while (ch!=0);
    } }
}
