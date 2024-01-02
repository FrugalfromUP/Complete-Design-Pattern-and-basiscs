using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Solid.SolidS
{
    public class ProcedureReport
    {
        public void GeneraReport(string PatientName)
        {
            Console.WriteLine($"Report is generated for {PatientName}.");
        }
    }
}
