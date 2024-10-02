using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Arrayl
    {
        static void Main()
        {
           ArrayList list = new ArrayList();

            list.Add(12);
            list.Add ("hello");
            list.Add (11.54);
            Console.WriteLine("Display the array list element");

            foreach(var item in list)
            {
                Console.WriteLine(item );
            }
            Console.ReadLine();

            list .Reverse();
            Console.WriteLine("Reverse array list");
            foreach (var item in list)
            {
                Console.WriteLine (item );
            }
            Console.ReadLine();
            list.RemoveAt (0);
            Console.WriteLine("Remove the element");
            foreach ( var item in list)
            {
                Console.WriteLine(item );
            }
            Console.ReadLine();
            list.Add(232);
            list.Add("madekar");
            Console.WriteLine("Add the element");
            foreach (var item in list )
            {
                Console.WriteLine(item );   
            }
            Console.ReadLine();     
            list.Clear();
            Console.WriteLine("clear the element");
            foreach (var item in list )
            {
                Console.WriteLine("clear the element");
            }
          Console.ReadLine ();

        }
    }
}
