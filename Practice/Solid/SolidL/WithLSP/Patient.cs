using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Solid.SolidL.WithLSP
{
    class Patient : Person
    {
        public string HealthCondition { get; set; }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Specialization: {HealthCondition}");
        }
    }
}
