using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Solid.SolidD.WithDIP
{
    public class SolidD
    {

        static void Main(string[] args)
        {
            IWoker doctor = new Doctor();
            Hospital hospital = new  Hospital(doctor);
            hospital.TreatMentPatient();
            Console.ReadKey();

        }
    }
}
