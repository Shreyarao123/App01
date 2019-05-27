using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay3
{
    class Exception3
    {
        static void Main(string[] args)
        {
            int? a = null;
            int? b = null;
            int? c = null;
            try
            {
                Console.Write("enter num 1:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter num2:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("division is :{0}",c);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("no can't be divisble by zero {0}",ex.Message);
            }
            Console.ReadKey();
        }
    }
}
