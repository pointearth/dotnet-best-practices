using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsageLibrary
{
    
    

    public class TestBadlyConstructedType
    {
        public static void Main()
        {
            DerivedType derivedInstance = new DerivedType();
            Console.ReadKey();
        }
    }

}
