using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsageLibrary
{
    public class DerivedType : BadlyConstructedType
    {
        public DerivedType()
        {
            Console.WriteLine("Calling derived ctor.");
            initialized = "Yes";
        }
        public override void DoSomething()
        {
            Console.WriteLine("Derived DoSomething is called - initialized ? {0}", initialized);
        }
    }
}
