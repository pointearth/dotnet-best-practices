using System;
using System.Collections.Generic;
using System.Text;

using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace TestDataAdapter
{
    class Program
    {
        static void Main(string[] args)
        {

            string sSQL = "select top 1000 * from OperationLog"; 
            string sConnString = "Server=(local);Database=Demo;	Integrated Security=SSPI;";
            DataSet oDs = new DataSet();
            SqlDataAdapter oDa = new SqlDataAdapter();
            Stopwatch sw = new Stopwatch();
            using (SqlConnection oCn = new SqlConnection(sConnString))
            {
                SqlCommand oSelCmd = new SqlCommand(sSQL, oCn);
                oSelCmd.CommandType = CommandType.Text;
                oDa.SelectCommand = oSelCmd;
                oCn.Open();
                sw.Start();
                for (int i = 0; i < 1000;i++ )
                    oDa.Fill(oDs, "OperationLog");
                sw.Stop();
            }
            Console.WriteLine("DataAdapter read finished , use {0} milliseconds ", sw.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
