using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leak
{
    delegate void MessageHandler(string msg);
    class MessagePublisher
    {
       
        public event MessageHandler OnMsgReceived;
        public void GetData(string data)
        {
            if (null != OnMsgReceived)
                OnMsgReceived(data);
        }
        

    }
}
