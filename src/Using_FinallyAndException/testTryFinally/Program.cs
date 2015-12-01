using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace testTryFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker curWorker = new Worker();
            
            curWorker.work();
               
            ///test try finlly

            //try
            //{
            //    curWorker.workSafety();
            //}
            //catch (Exception ex)
            //{

            //}
             
        }
    }
}
