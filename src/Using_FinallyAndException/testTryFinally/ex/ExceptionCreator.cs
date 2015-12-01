using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace testTryFinally
{
    public class ExceptionCreator
    {
        public void Say()
        {
            
            Say1();
        }
        public void Say1()
        {
            Say2();
        }
        public void Say2()
        {
            throw new NotImplementedException("error");
        }
       
    }
}
