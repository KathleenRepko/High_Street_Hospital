using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Street_Hospital
{
    class Doctor : GeneralEmployee
    {
        protected string specialtyArea;


        public Doctor()
        {
        }

        public Doctor(string employeeName, int employeeNumber, string specialtyArea) 
        {
            this.specialtyArea = specialtyArea;
        }

        public override string PrintEmployeeInfo()
        {
            return base.PrintEmployeeInfo() + "\t" + specialtyArea;
            
        }
    }

}
