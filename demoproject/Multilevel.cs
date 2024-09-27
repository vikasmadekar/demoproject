using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    class Person // base class
    {
        
       
        public string Name { get; set; }
        
       
           
    }

       
    class Teacher : Persion //Person cha  child class
    {
        public int id { get; set; }
        public float Salary { get; set; }
    }
    class Principle :Teacher// teacher cha child class
    {
        public void Display()
        {
            Console.WriteLine($"The person id:={id}");
            Console.WriteLine($"The name persion:{name}");
            
            Console.WriteLine($"The employee salary:{Salary }");

        }
         

    }
    internal class Multilevel
    {

        static void Main()
        {
            Principle principle = new Principle();
            
                principle.name = "vikas";
                principle.id = 1;
                principle.Salary = 500000.5F;


            principle.Display();
              
            
        }
    }
}
