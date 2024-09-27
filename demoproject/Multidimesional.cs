using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Multidimesional
    {
        static void Main()
        {
            int[,] arr= new int[3, 4]
            {
                 { 11 ,23 ,44 ,55 },

               { 12 ,23, 31, 66 },

                { 55 ,66 ,77 ,88  }


              };

            //for (int i = 0; i < arr.GetLength(0);i++)
            //{
              //  for(int j=0;j<arr.GetLength(1);j++)
                //{
                  //  Console.WriteLine(arr[i,j]);
               // }
                
           // }
           foreach (int i in arr)
            {

                Console.WriteLine(i);

            }

        }
    }
}
