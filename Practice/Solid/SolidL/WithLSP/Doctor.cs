using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Solid.SolidL.WithLSP
{
    class Doctor : Person
    {
        public string Specialization { get; set; }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Specialization: {Specialization}");
        }
    }

}
