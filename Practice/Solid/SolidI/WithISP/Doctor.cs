using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Solid.SolidI.WithISP
{
    public class Doctor : Iworker
    {
        public void Work()
        {
            Console.WriteLine("doctor is doing treatment");
        }
    }
}
