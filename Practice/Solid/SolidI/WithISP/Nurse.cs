using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Solid.SolidI.WithISP
{
    class Nurse : Iworker
    {
        public void Work()
        {
            Console.WriteLine("the nurse is taking care of patient");
        }
    }
}
