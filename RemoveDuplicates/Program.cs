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
            string Sentence ="Hii We are learning C# codekojkljkljkl";
            Console.WriteLine("Initial String: " + Sentence);
            var unique = new HashSet<char>(Sentence);
            Console.Write("New String after removing duplicates: ");
            foreach (char c in unique)
            {
                Console.Write(c);
            }            
            Console.ReadLine();
        }
    }
}
