using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMS
{
    class DelDemo2
    {
        static void Main()
        {
            sayDelegate sd = name => "hello" + name + "have a nice day.";
            calculatorDelegate cd = (a, b, c) => Console.WriteLine(a * b * c);
            Console.WriteLine(sd("raju"));
            Console.WriteLine(sd("naresh"));
            Console.WriteLine(sd("nacre"));
            cd(10, 20, 30); cd(40, 50, 60); cd(70, 80, 80);
            Console.ReadLine();


        }
    }
}
