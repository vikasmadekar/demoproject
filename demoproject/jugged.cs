using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Jugged
    { 

        static void Main()
        {
            int[][] arr = new int[3][];
            arr[0]=new int[] { 12,33};
            arr[1] = new int[] { 55, 66, 77 };
            arr[2] = new int[] { 99, 88, 33, 44 };
            arr[3] = new int[] { 11, 77, 99, 99 };
            for (int i=0;i<arr.GetLength(0);i++)
            {
               for(int j=0;j<arr.GetLength (1);j++)
                {
                    Console.WriteLine(arr[i][j]);
                }
            }
            
        }
    }
}
