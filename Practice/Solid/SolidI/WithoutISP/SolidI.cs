using Practice.Solid.SolidI.WithoutISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class SolidI
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor();
            Nurse nurse = new Nurse();
            Administrator administrator = new Administrator();
            Console.ReadKey();
        }
    }
}
