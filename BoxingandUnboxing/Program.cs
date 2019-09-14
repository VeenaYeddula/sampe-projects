using System;

namespace BoxingandUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boxing : value type to reference type
            int a = 10;
            object obj = a;
            Console.WriteLine("value type to reference type is:{0}", a);
            //UnBoxing : Reference type to Value type
            int i= (int)obj;
            Console.WriteLine("Reference type to value type is:{0}", i);

        }
    }
}
