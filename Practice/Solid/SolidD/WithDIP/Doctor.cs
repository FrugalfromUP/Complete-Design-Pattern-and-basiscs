using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Solid.SolidD.WithDIP
{
    internal class Doctor : IWoker
    {
        public void Treat()
        {
            Console.WriteLine("Doctor is treating patient");
        }
    }
}
