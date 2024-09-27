using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace demoproject
{   class Persion

    {
        
        public string name { get;set; } 
        public int age { get;set; }

    }
    class Student : Persion
    {
        public void Show()
        {
            Console.WriteLine($"persion name:={ name}");
            Console.WriteLine($"persion age:={ age}");
        }
    }
    internal class Singleinheritance
    {
        static void Main()
        {
             
            Student std = new Student();
            {
                std.name = "vikas";
                std.age = 16;

            };

            std.Show();
        }
    }
}
