using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Solid.SolidL.WIthoutLSP
{
    public class Doctor : Person
    {
        public string Specialization { get; set; }

        // Violation of LSP
        public override void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Specialization: {Specialization}");
        }
    }
}
