using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{


    internal class String_Filter
    {

        static bool StartsWithLetter(string str, char letter)
        {
            return str.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase);
        }

        static List<string> FilterStrings(List<string> strings, Predicate<string> predicate)
        {
            return strings.FindAll(predicate);
        }
        static void Main(string[] args)
        {

            List<string> names = new List<string> { "Ajit", "Baban", "Chandan", "Vikas", "Madekar", "Apsar" };

            Console.WriteLine("Enter a letter to filter names that start with it:");
            char letter = Console.ReadLine()[0];

            Predicate<string> predicate = str => StartsWithLetter(str, letter);
            List<string> filteredNames = FilterStrings(names, predicate);

            Console.WriteLine("Filtered names:");
            foreach (string name in filteredNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}

