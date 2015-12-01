using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUsing.Mine
{
    public class StreamWriter:IDisposable
    {
        private Stream _curStream;
        public StreamWriter(Stream stream)
        {
            
            _curStream = stream;
        }
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
            Console.WriteLine("Dispose StreamWriter");
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here. 
                //
                _curStream.Dispose();
            }

            // Free any unmanaged objects here. 
            //
            disposed = true;
        }

        ~StreamWriter()
        {
            Dispose(false);
        }
    }
}
