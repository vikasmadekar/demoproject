using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{


    class Negative_Number_Exception : Exception
    {
        public Negative_Number_Exception(string message) : base(message)
        {

        }





    } 
    internal class Custom_exception
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter the number");
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    throw new Negative_Number_Exception ("num is negative number");

                }
                else
                {
                    Console.WriteLine(num );
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message );
            }
        }
    }
}
