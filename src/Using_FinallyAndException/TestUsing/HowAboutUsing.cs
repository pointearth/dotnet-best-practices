using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestUsing.Mine;

namespace TestUsing
{
    public class HowAboutUsing
    {
        public void TestTryFinally()
        {
            Stream curStream = null;
            try
            {
                curStream = new Stream();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                curStream.Dispose();
            }
        }
        public void TestUsing()
        {
            using(Stream curStream = new Stream())
            {

            }
        }
    }
}
