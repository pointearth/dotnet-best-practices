using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCA1000
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericType<int>.GenericMethod();
            //GenericType<int>.GenericMethod<string>();
            GenericType<int> a = new GenericType<int>();
            a.GenericMethod<string>();
        }
    }
}
