using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Solid.SolidL.WIthoutLSP
{
    public class Person
    {
        public string Name { get; set; }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
        }

    }
}
