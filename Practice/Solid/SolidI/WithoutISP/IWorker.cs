﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Solid.SolidI.WithoutISP
{
    public interface IWorker
    {
        void Work();
        void AttendMeeting();
        void TakeBreak();
    }
}
