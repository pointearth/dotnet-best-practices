using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUsing.Mine
{
    public class FileStream:Stream
    {
        
        public FileStream(string filePath, FileMode mode)
        {

        }
        // Flag: Has Dispose already been called? 
        bool disposed = false;
       
        //// Public implementation of Dispose pattern callable by consumers. 
        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);//remove object from freachable queue
        //}
        protected override void Dispose(bool disposing)//because of a derived class ,this function must a "override" function to be invoked.
        {
            Console.WriteLine("Dispose FileStream");
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here. 
                //
            }

            // Free any unmanaged objects here. 
            //
            disposed = true;
            base.Dispose(disposing);// It is verty important to invoke base class Dispose function
        }

        ~FileStream()
        {
            Dispose(false);
        }
    }
}
