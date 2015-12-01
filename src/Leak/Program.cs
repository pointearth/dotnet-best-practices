using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Leak
{
    class Program
    {
        private const int _count = 1500;

        private static MessagePublisher _curPublisher = new MessagePublisher();

        static void Main(string[] args)
        {
           run();
           //runUnSubscrib();
            _curPublisher = null;//will remove all root.
            GC.Collect(); //warning: don't invoke this function in your program,it is only for test
            Console.ReadKey();
        }


        /// <summary>
        /// run without remove subscrib
        /// </summary>
        private static void run()
        {
            MessageWatcher[] curSaverArray = new MessageWatcher[_count];
            for (int i = 0; i < _count; ++i)
            {
                curSaverArray[i] = new MessageWatcher();
                _curPublisher.OnMsgReceived += curSaverArray[i].SaveMessage;
            }
            _curPublisher.GetData("test");


            curSaverArray = null;
        }








        /// <summary>
        /// run and unsubscribEvent
        /// </summary>
        private static void runUnSubscrib()
        {
            MessageWatcher[] curSaverArray = new MessageWatcher[_count];
            for (int i = 0; i < _count; ++i)
            {
                curSaverArray[i] = new MessageWatcher();
                _curPublisher.OnMsgReceived += curSaverArray[i].SaveMessage;
            }
            _curPublisher.GetData("test");
            
            //unsubscrib
            for (int i = 0; i < _count; ++i)
            {
                _curPublisher.OnMsgReceived -= curSaverArray[i].SaveMessage;
            }

            curSaverArray = null;
        }
    }
}
