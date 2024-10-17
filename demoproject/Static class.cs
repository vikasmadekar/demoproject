using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    static class CatWorld
    {
        public static int NumberOfCats { get; set; }
        public static int TotalCatNaps { get; set; }
        static CatWorld()
        {
            NumberOfCats = 10;
        }
        public static void AddCat()
        {
            Console.WriteLine($"Current Cat Count Is:- {NumberOfCats}");
            NumberOfCats++;
            Console.WriteLine($"\nNew Cat Has Joined The Current Count Is:- {NumberOfCats}\n");
        }
    }
     internal class StaticClass
    {
        static void Main()
        {
            CatWorld.AddCat(); //New Cat Joined
            CatWorld.AddCat();//Another New cat Joined
        }
   
    
               
        }
      
        
           
}