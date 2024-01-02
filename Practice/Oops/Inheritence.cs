using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Inheritence :InheritenceBase
    {
        public int MyProperty = 2;
        public Inheritence()
        {
            Console.WriteLine("Ritesh");
        }
    }

    public class InheritenceBase
    {
        public int MyProperty1 = 2;
        public InheritenceBase()
        {
            Console.WriteLine("Base");
        }
    }
}
