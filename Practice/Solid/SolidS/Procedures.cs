using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Solid.SolidS
{
    //here we have a class which has all the funtion which is supposed to be procedure  
    public class Procedures
    {

        public void AdmitPatient(string PatientName)
        {
            Console.WriteLine($"Patient {PatientName} is admitted");
        }

        public void PerformSurgery(string PatientName) {
            Console.WriteLine($"Surgery performed on Patient {PatientName}");
        }
        public void GeneraReport(string PatientName) {
            Console.WriteLine($"Report is generated for {PatientName}.");
        }
    }
}
