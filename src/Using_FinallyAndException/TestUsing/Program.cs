using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using System.IO;
using TestUsing.Mine;

namespace TestUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 what essence using is?
            //using (Stream stream = new Stream())
            //{
                
            //}
            
            //2 CA2202: Do not dispose objects multiple times
            //using (Stream stream = new FileStream("file.txt", FileMode.OpenOrCreate))
            //{
            //    using (StreamWriter writer = new StreamWriter(stream))
            //    {
            //        // Use the writer object...
            //    }
            //}

            ////3 what we should done ?
            Stream stream = null;
            try
            {
                stream = new FileStream("file.txt", FileMode.OpenOrCreate);
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    stream = null;
                    // Use the writer object...
                }
            }
            finally
            {
                if (stream != null)
                    stream.Dispose();
            }



            //Write code that avoids exceptions
            //NotUseException ne = new NotUseException();
            ////bool result =  ne.IsInt("dfs");
            //bool result = ne.IsIntCorrect("dfd");
            //Console.WriteLine(String.Format("parameter is int ? {0}",result));
           



            Console.ReadKey();

        }
    }
}
