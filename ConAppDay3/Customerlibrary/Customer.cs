using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customerlibrary
{
    public class Customer
    {
        
            private int phnnum;
            private string sname, email;
            public Customer(string sname, string email, int phnnum)
            {
                this.sname = sname;
                this.email = email;
                this.phnnum= phnnum;
            }
            public void GetDetails()
            {
                Console.WriteLine("sname={0}, email={1},phnnum={2}", this.sname, this.email, this.phnnum);
            }
        }
    }

