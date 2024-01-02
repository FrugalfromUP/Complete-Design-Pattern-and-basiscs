using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Solid.SolidO
{
    public class Hospital
    {
        public string HospitalName { get; set; }
        //Do this in case without OCP
        //public List<Doctor> Doctors { get; set; } = new List<Doctor>();
        //Add this below line in case of With OCP
        public List<IStaffTreat> staffTreats { get; set; } = new List<IStaffTreat>();

    }
}
