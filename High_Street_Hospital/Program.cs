using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Street_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor("Jack", 137, "Ear, Nose, Throat");

            Doctor doctor2 = new Doctor("Colin", 816, "Heart");

            Surgeon surgeon1 = new Surgeon("Sean", 246, "Brain", false);

            Surgeon surgeon2 = new Surgeon("J.A.", 538, "Lung", true);

            Nurse nurse1 = new Nurse("Stimpy", 216, "Pediatrics", 6);

            Nurse nurse2 = new Nurse("Dawn", 357, "Radiology", 5);

            Receptionist receptionist1 = new Receptionist("Kathy", 422, "Emergency", true);

            Receptionist receptionist2 = new Receptionist("Josh", 618, "Oncology", false);


            Console.WriteLine(doctor1.PrintEmployeeInfo());
            Console.WriteLine(doctor2.PrintEmployeeInfo());
            Console.WriteLine(surgeon1.PrintEmployeeInfo());
            Console.WriteLine(surgeon2.PrintEmployeeInfo());
            Console.WriteLine(nurse1.PrintEmployeeInfo());
            Console.WriteLine(nurse2.PrintEmployeeInfo());
            Console.WriteLine(receptionist1.PrintEmployeeInfo());
            Console.WriteLine(receptionist2.PrintEmployeeInfo());

        }

    }
}

