using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay3
{
    class Exception4
    {
        static void Main(string[] args)
        {
            int[] items = { 10, 20, 30, 40, 50 };
            try
            {
                for (int i=0;i<=items.Length;i++)
                    Console.WriteLine(items[i]);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("out of bounds,{0}",ex.Message);
            }
            Console.ReadKey();
        }
    }
}
