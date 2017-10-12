using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Street_Hospital
{
    class Surgeon : Doctor
    {
        protected bool isOperating;

        //public bool IsOperating
        //{
        //    get { return this.isOperating; }
        //    set { this.isOperating = isOperating; }
        //}

        public Surgeon()
        {
        }

        public Surgeon(string employeeName, int employeeNumber, string specialtyArea, bool isOperating) 
        {
            this.isOperating = isOperating;
        }


        public override string PrintEmployeeInfo()
        {
            return base.PrintEmployeeInfo() + "\t" + "Is Operating = " + isOperating;

        }
    }
}
