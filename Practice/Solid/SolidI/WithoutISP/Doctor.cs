using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Solid.SolidI.WithoutISP
{
    public class Doctor : IWorker

    {
        public void AttendMeeting()
        {
            Console.WriteLine("DR. Attending meeting");
        }

        public void TakeBreak()
        {
            Console.WriteLine("Dr. On break");
        }

        public void Work()
        {
            Console.WriteLine("Dr. treating patient");
        }
    }
}
