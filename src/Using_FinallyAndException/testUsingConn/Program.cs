using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace testUsingConn
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection conn = new SqlConnection("server=localhost;database=policeInfoDB;uid=sa;pwd=cxmcxm-123"))
            {
                using (SqlCommand cmd = new SqlCommand("select * from userInfo", conn))
                {
                    conn.Open();
                     cmd.ExecuteReader();
                }
            }
            Console.ReadKey();
        }
    }
}
