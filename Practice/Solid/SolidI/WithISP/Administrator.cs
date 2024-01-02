using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Solid.SolidI.WithISP
{
    public class Administrator : ITakeBreak,IAttendMeeting
    {
        public void AttendMeeting()
        {
            Console.WriteLine("Admin attending meeting ");
        }

        public void TakeBreak()
        {
            Console.WriteLine("admin is on break");
        }
    }
}
