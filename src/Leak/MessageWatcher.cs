using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leak
{
    class MessageWatcher
    {
        private byte[] _cache;
        public MessageWatcher()
        {
            _cache = new byte[1024 * 1024];
        }
        public void SaveMessage(string msg)
        {
            Console.WriteLine(String.Format("get messag:{0}",msg));
            Console.WriteLine("Saving...");
            //save msg...
            Console.WriteLine("Saved");
        }
    }
}
