using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTryFinally
{
    public class ExceptionShell
    {
        
        public void Say()
        {

            try
            {
                ExceptionCreator curCreator = new ExceptionCreator();
                curCreator.Say();
            
            }
            catch(Exception ex)
            {
                //throw ex;
                throw;
            }
        }
    }
}
