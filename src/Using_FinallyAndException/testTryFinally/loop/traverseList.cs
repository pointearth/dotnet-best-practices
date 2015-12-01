using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using 

namespace testTryFinally.loop
{
    class traverseList<T>
    {
        public void work(List<T> target)
        {
            Task curTask = new Task();
            foreach(T curT in target)
            {
                Console.WriteLine(curT);
                curTask.Wait(3000);
            }
        }
    }
}
