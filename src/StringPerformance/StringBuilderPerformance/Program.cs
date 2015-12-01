using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text;
//using System.Threading.Tasks;
using System.Diagnostics;

namespace StringBuilderPerformance
{

    class Program
    {
        private const string INFO = "info";
        private const int LOOPCOUNT = 100000;
        static void Main(string[] args)
        {
            Console.WriteLine("begain add string by StringBuilder -----------------------");
            Console.Out.Flush();

            Stopwatch wStB = new Stopwatch();
            wStB.Start();
            StringBuilder builderInfo = new StringBuilder("begin:", 400006);//6 + 100000 * 4);
            for (int i = 0; i < LOOPCOUNT; ++i)
                builderInfo.AppendLine(INFO); //Append(INFO);
            wStB.Stop();
            Console.WriteLine("mission 2 compelet,spend {0} ms", wStB.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
