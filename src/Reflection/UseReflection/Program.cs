using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
using System.Diagnostics;

namespace UseReflection
{
    class Program
    {
        private const int LoopCount = 100000;
        static void Main(string[] args)
        {
            Console.WriteLine("begain invoke with reflection -----------------------");
            Console.Out.Flush();
            Assembly assembly = Assembly.LoadFile(@"D:\work\codereview\labs\TargetLab\bin\Debug\TargetLab.dll");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < LoopCount;++i )
            {
                Type t = assembly.GetType("TargetLab.SomeLabrary");
                MethodInfo method = t.GetMethod("SelfAction");
                Object o = Activator.CreateInstance(t);
                BindingFlags  flag  =  BindingFlags.Public  |  BindingFlags.Instance;
                //object[] parameters = new object[] { "abc" };
                object[] parameters = new object[] {};
                method.Invoke(o, flag, Type.DefaultBinder, parameters, null);
            }

            sw.Stop();
            Console.WriteLine(string.Format("spend {0} ms for {1} times Reflected invoke",sw.ElapsedMilliseconds,LoopCount));
            Console.ReadKey();
        }
    }


    //Stopwatch sw = new Stopwatch();
    //sw.Start();


    //sw.Stop();
    //Console.WriteLine(string.Format("spend {0} ms for {1} times sample invoke",sw.ElapsedMilliseconds,LoopCount));

}
