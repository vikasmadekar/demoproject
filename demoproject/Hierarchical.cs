using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
   public   class Shape5
    {
      public   string  color;
            public void DisplayDetails()
        {
            Console.WriteLine(color);
        }
    }
   public  class Circle3:Shape5
    {
       public  Circle3 (string color)
        {
            this.color = color;
        }

    }
    public class Rectangle4:Shape5
    {
       public   Rectangle4 (String color)
        {
            this.color = color;
        }
    }
    internal class Hierarchical
    {
        static void Main()
        {
            Circle3 circle =new Circle3("Yellow");
            Console.Write("Circle color");
            circle .DisplayDetails();
            Rectangle4  rec=new Rectangle4("Black");
            Console.Write("Rectangle color ");
            rec.DisplayDetails();

            
        }
            
    }
}
