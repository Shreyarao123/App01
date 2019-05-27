using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC
{
    public class Employee
    {
        
            private string  empname, address, city, department;
            private int salary,empid;
            public void SetDetails(int empid, string empname, string address, string city, string department, int salary)
            {
                this.empid = empid;
                this.empname = empname;
                this.address = address;
                this.city = city;
                this.department = department;
                this.salary = salary;


            }
            public void GetSalary()
            {
                Console.WriteLine("salary={0}", this.salary);
            }

        }
    }



