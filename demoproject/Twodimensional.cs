using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Twodimensional
    {

        static void Main()
        {
            int[,] arr = new int[3, 4]
            {
                {11,22,33,44 },
                { 44,55,66,77},
                { 99,11,33,88},
            };
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    Console.WriteLine (arr[i,j]);
                }
            }
        }
    }
}
