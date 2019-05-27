using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Employeelibrary
{
    public class Employee
    {
        private string empid,empname,address,city,department;
        private int salary;
        public Employee(string empid,string empname,string address,string city,string department,int salary)
        {
            this.empid = empid;
            this.empname = empname;
            this.address = address;
            this.city = city;
            this.department = department;
            this.salary = salary;


        }
        public void GetDetails()
        {
            Console.WriteLine("empid={0},empname={1},address={2},city={3},department={4},salary={5}",this.empid,this.empname,this.address,this.city,this.department,this.salary);
        }

    }
}
