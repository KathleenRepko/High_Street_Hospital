using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Street_Hospital
{
    class GeneralEmployee
    {
        protected string employeeName;
        protected int employeeNumber;

        //public string EmployeeName
        //{
        //    get { return this.employeeName; }
        //    set { this.employeeName = value; }
        //}

        //public int EmployeeNumber
        //{
        //    get { return this.employeeNumber; }
        //    set { this.employeeNumber = value; }
        //}

        public GeneralEmployee()
        {
    
        }

        public GeneralEmployee(string employeeName, int employeeNumber)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
        }


        public virtual string PrintEmployeeInfo()
        {
            return "Employee Name: " + employeeName + "\t" + "Employee Number: " + employeeNumber;
        }



    }
}
