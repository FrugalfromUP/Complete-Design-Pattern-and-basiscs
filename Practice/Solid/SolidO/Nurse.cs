using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Solid.SolidO
{
    public class Nurse : IStaffTreat
    {
        public string Name { get; set; }
        public void TreatPatient(string Name)
        {
            Console.WriteLine($"Nurse {Name} is Taking care of a patient");
        }
    }
}
