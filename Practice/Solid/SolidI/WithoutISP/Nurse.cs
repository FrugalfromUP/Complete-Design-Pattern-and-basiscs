using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Solid.SolidI.WithoutISP
{
    public class Nurse : IWorker
    {
        public void AttendMeeting()
        {
            Console.WriteLine("Nurse is Attending meeting");
        }

        public void TakeBreak()
        {
            Console.WriteLine("Nurse is on break"); ;
        }

        public void Work()
        {
            Console.WriteLine("Nurse is taking care of patient");
        }
    }
}
