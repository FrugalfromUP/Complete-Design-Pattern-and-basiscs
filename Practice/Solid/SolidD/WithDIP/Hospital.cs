using Practice.Solid.SolidI.WithoutISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Solid.SolidD.WithDIP
{
    public class Hospital 
    {
        private readonly IWoker _woker;
        public Hospital( IWoker woker)
        {
            _woker = woker;                
        }

        public void TreatMentPatient()
        {
            _woker.Treat();
        }
    }
}
