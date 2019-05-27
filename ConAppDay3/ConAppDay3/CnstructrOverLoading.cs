using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Constructor Overloading
namespace ConAppDay3
{
    class person
    {
        private string pname, gender;
        public person()
        {
            this.pname = "not provided";
            this.gender = "female";
        }
        public person(string pname,string gender)
        {
            this.pname = pname;
            this.gender = gender;

        }
        public void GetDetails()
        {
            Console.WriteLine("name={0},gender={1}",this.pname,this.gender);
        }
    }
    class CnstructrOverLoading
    {
        static void Main(string[] args)
        {
            person p1 = new person();
            person p2 = new person();
            p1.GetDetails();
            p2.GetDetails();
            Console.ReadKey();

        }
        

    }
}
