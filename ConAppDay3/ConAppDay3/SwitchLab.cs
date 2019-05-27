using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay3
{
    class SwitchLab
{
        static void Main(string[] args)
        {
            //Console.WriteLine("enter a number");
            int n = Convert.ToInt32(args[0]);
            switch (n)
            {
                case 1:
                    Console.WriteLine("the enter value is{0} ",n);

                  
                    break;
                case 2:
                    Console.WriteLine("the enter value is{0}",n);
                   
                    break;
                case 3:
                    Console.WriteLine("the enter value is{0}",n);
                   
                    break;
                case 4 :
                    Console.WriteLine("the value is{0}",n);
                    break;
             default:
                    Console.WriteLine("invalid input",n);
                    break;
            }
            Console.ReadKey();



        }
    }
}
