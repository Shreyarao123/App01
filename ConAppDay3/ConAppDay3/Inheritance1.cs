using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay3
{
    class Inheritance1
    {
        class Base
        {
            private int dm1 = 1000;
            protected int dm2 = 2000;
            public int dm3 = 3000;
            public void DisplayBase()
            {
                Console.WriteLine("dm1={0},dm2= {1},dm3= {2}", dm1, dm2, dm3);
            }
        }
        class Derived : Base
        {
            public void DisplayDerived()
            {
                Console.WriteLine("dm1={0}, dm2= {1}", dm2, dm3);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                //Base o1 = new Base();
                Derived o1 = new Derived();
                o1.DisplayBase();
                o1.DisplayDerived();
                Console.ReadKey();
            }
        }
    }
}
