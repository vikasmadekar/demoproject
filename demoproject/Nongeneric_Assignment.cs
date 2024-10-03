using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace demoproject
{
    internal class Nongeneric_Assignment
    {
        static void Main()
        {
            Stack st = new Stack();
            st.Push(12);
            st.Push(13);
            st.Push("vikas");
            st.Push(233);
            st.Push('V');
            Console.WriteLine("stack element");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            st.Pop();
            st .Pop();
            st.Pop();
         Console.WriteLine("Remove the element");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            st .Clear();
            Console.WriteLine("clear the element");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

        }
    }
}



