using System;
using System.Collections.Generic;
using System.Text;

using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
namespace TestDataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            List<OperationLog> result = new List<OperationLog>();
            string sSQL = "  select top 1000 * from OperationLog";
            string sConnString = "Server=(local);Database=Demo;	Integrated Security=SSPI;";
            Stopwatch sw = new Stopwatch();
            SqlDataReader oDr = null;
            using (SqlConnection oCn = new SqlConnection(sConnString))
            {
                SqlCommand oSelCmd = new SqlCommand(sSQL, oCn);
                oSelCmd.CommandType = CommandType.Text;
                oCn.Open();
                sw.Start();
                for (int i = 0; i < 1000; i++)
                {
                    oDr = oSelCmd.ExecuteReader();
                    while (oDr.Read())
                    {
                        //OperationLog curLog = new OperationLog();
                        ////add to list
                        //curLog.ID = Convert.ToInt32(oDr["ID"]);
                        //curLog.LogTime = Convert.ToDateTime(oDr["LogTime"]);
                        //curLog.CustomerID = Convert.ToInt32(oDr["CustomerID"]);
                        //curLog.MobileNo = oDr["MobileNo"].ToString();
                        //result.Add(curLog);
                    }
                   
                    oDr.Close();
                }

                sw.Stop();
            }
            Console.WriteLine("DataAdapter read finished , use {0} milliseconds ", sw.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
