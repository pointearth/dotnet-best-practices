using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace testTryFinally
{
    public class Worker
    {
        MemoryStream curS = null;
        public void work()
        {
           
            try
            {
                ExceptionShell curShell = new ExceptionShell();
                curShell.Say();
            }
            catch(Exception ex)
            {
                //log stack
            }
        }

        public void workSafety()
        {
            try
            {
                curS = new MemoryStream(500); 
                throw new Exception("error");
            }
           //catch(Exception ex)
           // {

           //}
            finally
            {
               
            }
            curS.Dispose();
           
        }
    }
}
