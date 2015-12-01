using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUsing.Mine
{
    public class Stream:IDisposable
    {
        // Flag: Has Dispose already been called? 
        bool disposed = false;
       
        // Public implementation of Dispose pattern callable by consumers. 
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);//remove object from freachable queue
        }
        protected virtual void Dispose(bool disposing)
        {
            Console.WriteLine("Dispose Stream");
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
        }

        ~Stream()
        {
            Dispose(false);
        }

    }
}
