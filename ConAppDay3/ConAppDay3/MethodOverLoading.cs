using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay3
{
    class test
    {
        public void display()
        {
            Console.WriteLine("hello friend!");
        }
        public void display(string name)
        {
            Console.WriteLine("hello {0}",name);
        }
    }
    class MethodOverLoading
    {
        static void Main(string[] args)
        {
            test o = new test();
            o.display();
            o.display("raj");
            Console.ReadKey();

        }
    }
}
