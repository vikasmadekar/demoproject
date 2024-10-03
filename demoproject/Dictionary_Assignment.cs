using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace demoproject
{
    internal class Dictionary_Assignment
    {
        static void Main()
        {
            Dictionary<string ,int > dict = new Dictionary<string ,int>();
            
                dict.Add("Apple", 75000);
                dict.Add("vivo", 10000);
                dict.Add("samsung", 20000);
                dict.Add("oppo", 15000);
                dict.Add("moto", 30000);
            dict.Add("techno", 12000);
            dict.Add("redme", 17000);
            dict.Add("pro", 110000);
            dict.Add("itel", 80000);
            dict.Add("karban",50000);



            Console.WriteLine("Display the element");
            foreach (KeyValuePair<string,int> kvp in dict)
            {
                Console.WriteLine(kvp.Key); 
            }
            Console.ReadLine();
            dict.Remove("Apple");
            Console.WriteLine("cut the element");
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine(kvp.Key);
            }
            Console .ReadLine();
            dict .Clear();
            Console.WriteLine("clear the element");
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine(kvp.Key);
            }

            
            
        }
    }
}
