using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay3
{
    class Exception1
    {
        static void Main(string[] args)
        {

            Console.Write("enter an integer:");
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("given num is {0}", n);
            }
            catch
            {
                Console.WriteLine("error");
            }
            Console.ReadKey();

            
        }
    }
}
