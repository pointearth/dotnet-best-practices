using System;
using System.Collections.Generic;


//using System.Threading.Tasks;

using System.Diagnostics;

namespace stringPerformance
{
    class Program
    {
        private const string INFO = "info";
        private const int LOOPCOUNT = 10;
        static void Main(string[] args)
        {
            Console.WriteLine("begain add string by String -----------------------");
            Console.Out.Flush();

            Stopwatch wStr = new Stopwatch();
            wStr.Start();
            String basicInfo = "begin:";
            for (int i = 0; i < LOOPCOUNT; ++i)
            {
                basicInfo += new string[500];
            }
                
            wStr.Stop();
            Console.WriteLine("mission compelet,spend {0} ms", wStr.ElapsedMilliseconds);

           

            //Stopwatch fStr = new Stopwatch();
            //fStr.Start();
            //String basicInfo = "begin:";
            //for (int i = 0; i < LOOPCOUNT; ++i)
            //    //String.Format("{0}{1}{0}{1}{0}{1}{0}{1}{0}{1}", basicInfo, i);
            //    basicInfo = "begin" + i + "begin" + i + "begin" + i + "begin" + i + "begin" + i;
            //fStr.Stop();
            //Console.WriteLine("mission 3 compelet,spend {0}", fStr.ElapsedMilliseconds);



            Console.ReadKey();

        }
    }
}
