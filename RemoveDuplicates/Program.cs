using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            string myStr ="mmnnop";
            Console.WriteLine("Initial String: " + myStr);
            var unique = new HashSet<char>(myStr);
            Console.Write("New String after removing duplicates: ");
            foreach (char c in unique)
                Console.Write(c);
        }
    }
}
