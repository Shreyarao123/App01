using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    class student
    {
        private int fee;
        private string sname, course;
        public student(string sname,string course,int fee)
        {
            this.sname = sname;
            this.course = course;
            this.fee = fee;
        }
        public void GetDetails()
        {
            Console.WriteLine("sname={0},course={1},fee={3}",this.sname,this.course,this.fee);
        }

    }
}
