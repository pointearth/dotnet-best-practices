using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Diagnostics;
using TargetLab;

namespace InvokeWithoutReflection
{
    class Program
    {
        private const int LoopCount = 100000;
        static void Main(string[] args)
        {
            Console.WriteLine("begain invoke with reflection -----------------------");
            Console.Out.Flush();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < LoopCount; ++i)
            {
                TargetLab.SomeLabrary lab = new SomeLabrary();
                lab.SelfAction();
                //lab.SelfAction("abc");
            }

            sw.Stop();
            Console.WriteLine(string.Format("spend {0} ms for {1} times sample invoke", sw.ElapsedMilliseconds, LoopCount));
            Console.ReadKey();
        }
    }
}
