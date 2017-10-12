using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Street_Hospital
{
    class NonDoctor : GeneralEmployee
    {
        protected string department;

        //public string Department
        //{
        //    get { return this.department; }
        //    set { this.department = value; }
        //}


        public NonDoctor()
        {

        }

        public NonDoctor(string employeeName, int employeeNumber, string department)
        {
            this.department = department;
        }


        public override string PrintEmployeeInfo()
        {
            return base.PrintEmployeeInfo() + "\t" + "Department: " + department;

        }
    }
        
}
