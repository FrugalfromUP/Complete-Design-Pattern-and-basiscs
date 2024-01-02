using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Solid.SolidD.WitoutDIP
{
    // Low-level module
    public class Doctor
    {
        public void Treat()
        {
            Console.WriteLine("Doctor is treating the patient.");
        }
    }
}
