using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{


    internal class Func_Concat_Positive
    {
        public static string Concat_String(string s1, string s2, string s3)
        {
            string str = s1.ToString() + s2.ToString() + s3.ToString();
            return str;
        }
        public static string Positive_Number(int number)
        {
            if (number > 0)
            {
                return "positive No";
            }
            else if (number < 0)
            {
                return "Negetive No";
            }
            else
            {
                return "Number is zero";
            }

        }
        static void Main(string[] args)
        {

            Func<string, string, string, string> obj1 = Concat_String;
            string str = obj1.Invoke("Vikas", " ", "Madekar");
            Console.WriteLine(str);
            Func<int, string> obj = Positive_Number;
            string s = obj.Invoke(12);
            Console.WriteLine(s);
        }
    }
}


