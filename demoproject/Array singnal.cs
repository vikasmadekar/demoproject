using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Array_singnal
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 5, 6, 6, 7, 7, };
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
