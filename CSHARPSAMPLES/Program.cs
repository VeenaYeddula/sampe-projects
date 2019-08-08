using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class Polindrome
    {
        static void Main(string[] args)
        {
            string[] arr = { "veena", "malayam", "rose", "ram", "madam", "kayak", "lotus", "pavan", "pavani", "pinky" };
            foreach (var words in arr)
            {
                string s, revs = "";
                Console.WriteLine("enter a string");
                s = Console.ReadLine();
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    revs += s[i].ToString();
                }

                if (s == revs)
                {
                    Console.WriteLine("string is a polindrome");
                }
                else
                {
                    Console.WriteLine("string is not a polindrome");
                }
                Console.ReadLine();
            }
        }
    }
}



