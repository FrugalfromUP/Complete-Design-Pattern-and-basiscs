using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Solid.SolidI.WithoutISP
{
    public class Administrator : IWorker
    {
        public void AttendMeeting()
        {
            Console.WriteLine("Attending meeting");
        }

        public void TakeBreak()
        {
            Console.WriteLine("On break");
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
