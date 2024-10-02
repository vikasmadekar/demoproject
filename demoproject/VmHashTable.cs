using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class VmHashTable
    {
        static void Main()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("name", "vikas");
            hashtable.Add("id", 20);
            hashtable.Add("phone no", 123456789);
            hashtable.Add("salary", 123);
            Console.WriteLine("Display the element");
             
            foreach (var item in hashtable)
            {
                Console.WriteLine(item );
            }
            Console.ReadLine ();
            hashtable.Remove("id");
            Console.WriteLine("element the remove");
            foreach (var item in hashtable)
            {
                Console.WriteLine(item );
            }
        }
    }
}
