using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    class calc
    {
        public int a, b,n;
        public void SetDetails(int a,int b)
        {
            this.a = a;
            this.b = b;
            switch (n)
            {
                case '1':
                    Console.WriteLine("addition");
                    Console.WriteLine("{0},{1},{2}", a, b, a + b);
                    break;
                case '2':
                    Console.WriteLine("substaction");
                    Console.WriteLine("{0},{1},{2}", a, b, a - b);
                    break;
                case '3':
                    Console.WriteLine("multiply");
                    Console.WriteLine("{0},{1},{2}", a, b, a * b);
                    break;
                case '4':
                    Console.WriteLine("division");
                    Console.WriteLine("{0},{1},{2}", a, b, a / b);
                    break;
                default:
                    Console.WriteLine("operator is not correct");
                    break;
            }

        }
        public void GetDetails()
        {
            Console.WriteLine("a={0},b={1}",a,b);
        }

    }
}
