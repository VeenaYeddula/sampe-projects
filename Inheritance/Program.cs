using System;

namespace Inheritance
{
    public class A
    {
       public void Method1()
        {
            Console.WriteLine("calling method1");
        }
        public void Method2()
        {
            Console.WriteLine("calling method2");
        }
    }
  public class B:A
    {
        public void Method3()
        {
            Console.WriteLine("calling method3");
        }
        public void Method4()
        {
            Console.WriteLine("calling method4");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            B obj = new B();
            obj.Method1();
            obj.Method1();
            obj.Method3();
            obj.Method3();
            obj.Method4();
            Console.ReadLine();
        }
    }
}
