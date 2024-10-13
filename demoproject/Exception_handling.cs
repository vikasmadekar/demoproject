using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Exception_handling
    {

        static void Main()
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
                Console.WriteLine(c);

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("out put send kr");
                Console.WriteLine(ex.Message);
            }
            try
            {
                int[] array = new int[3];
                array[0] = 1;
                array[1] = 2;
                array[2] = 3;
                array[3] = 4;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("out put send kr");
                Console.WriteLine(ex.Message );
            }
        }
    }
}
