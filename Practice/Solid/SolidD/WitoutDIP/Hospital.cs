using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Solid.SolidD.WitoutDIP
{
    //High level module 
    public class Hospital
    {
        private Doctor doctor;

        public Hospital()
        {
            this.doctor = new Doctor();
        }

        public void TreatPatient()
        {
            doctor.Treat();
        }
    }
}
