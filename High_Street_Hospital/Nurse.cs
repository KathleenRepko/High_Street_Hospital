using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Street_Hospital
{
    class Nurse : NonDoctor
    {
        protected int patientCount;

        //public int PatientCount
        //{
        //    get { return this.patientCount; }
        //    set { this.patientCount = value; }
        //}
        

        public Nurse()
        {

        }
        public Nurse (string employeeName, int employeeNumber, string department, int patientCount)
        { 
            this.patientCount = patientCount;
        }


        public override string PrintEmployeeInfo()
        {
            return base.PrintEmployeeInfo() + "\t" + "Patient Count: " + patientCount;

        }
    }
}
