using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay3
{
    class Cmmnd2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello {0}",args[0]);
            Console.WriteLine("length of {0} is {1}",args[0],args[0].Length);
            Console.ReadKey();
        }
    }
}
