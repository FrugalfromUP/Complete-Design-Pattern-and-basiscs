using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Solid.SolidO
{
    public interface IStaffTreat
    {
        string Name { get; }
        void TreatPatient(string Name);
    }
}
