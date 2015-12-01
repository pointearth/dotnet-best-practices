using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsageLibrary
{
    public class BadlyConstructedType
    {
        protected string initialized = "No";

        public BadlyConstructedType()
        {
            Console.WriteLine("Calling base ctor.");
            // Violates rule: DoNotCallOverridableMethodsInConstructors.
            DoSomething();
        }
        // This will be overridden in the derived type. 
        public virtual void DoSomething()
        {
            Console.WriteLine("Base DoSomething");
        }
    }
}
