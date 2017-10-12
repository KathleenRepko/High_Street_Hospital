using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Street_Hospital
{
    class Receptionist : NonDoctor
    {
        protected bool onPhone;

        //public bool OnPhone
        //{
        //    get { return this.onPhone; }
        //    set { this.onPhone = value; }
        //}


        public Receptionist()
        {

        }

        public Receptionist(string employeeName, int employeeNumber, string department, bool onPhone) 
        {
            this.onPhone = onPhone;
        }


        public override string PrintEmployeeInfo()
        {
            return base.PrintEmployeeInfo() + "\t" + "On phone = " + onPhone;

        }

    }

    
}
