using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    class Circle
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing the circle");
        }



    }
    class Rectangle : Circle
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing the Rectangle");

        }
    }

    internal class Animal
    {
        static void Main()
        {
            Circle c1 = new Circle();

            Rectangle rect = new Rectangle();

            c1.Draw();
            rect.Draw();


        }

    }
}






    

   

