using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Solid.SolidO
{
    //do not Implement interface in case of with out OCP
    public class Doctor : IStaffTreat
    {
        public string Name { get; set; }
        public string Specialisaiton { get; set; }

        public void TreatPatient(string doctorName)
        {
            Console.WriteLine( $"Dr. {doctorName} is checking patient");
        }
    }
}
