using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Arrreverse
    {
        static void Main()
        {
            int[] i = { 1, 2, 3, 4, 5 };
            int left = 0;
            int right = i.Length - 1;
            while(left <right)
            {
                int temp = i[left];
                i[left] = i[right];
                i[right] = temp;
                left++;
                right--;
                

            }
        }public static void Main(string[] args)
        {
            Console.WriteLine("madekar");
        }

    }
}