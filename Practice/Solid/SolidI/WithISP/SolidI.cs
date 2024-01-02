using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Solid.SolidI.WithISP
{
    public class SolidI
    {
        static void Main(string[] args)
        {

            Doctor doctor = new Doctor();
            Administrator administrator = new Administrator();
            Nurse Nurse = new Nurse();
            Console.ReadKey();  

        }

    }
}
