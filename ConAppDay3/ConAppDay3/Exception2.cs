using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay3
{
    class Exception2
    {
        static void Main(string[] args)
        {
            Console.Write("enter an integer:");
            int ?n = null; 
            try
            {
                 n = Convert.ToInt32(Console.ReadLine());

                
            }
            catch(FormatException ex)
            {
                Console.WriteLine("invalid type {0}",ex.Message);
                n = 0;
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("ip out of range{0}",ex.Message);
                n = int.MaxValue;
            }
            finally
            {
                Console.WriteLine("given num is{0}",n);
            }
            Console.ReadKey();

        }
    }
}
