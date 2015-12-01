using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using System.Transactions;

namespace MSDTC
{
    public partial class Form1 : Form
    {
        private static string connectString1 = null;
        private static string connectString2 = null;
        private const string commandText1 = "update operationLog set [MobileNo] =  [MobileNo] where id = 1000000";
        private const string commandText2 = "update operationLog set [MobileNo] =  [MobileNo] where id = 100000";
        public Form1()
        {
            InitializeComponent();
            connectString1 = System.Configuration.ConfigurationManager.ConnectionStrings["conn1"].ToString();
            connectString2 = System.Configuration.ConfigurationManager.ConnectionStrings["conn2"].ToString();
        }

        //private void btnMSDTC_Click(object sender, EventArgs e)
        //{
           
        //    Stopwatch sw = new Stopwatch();
        //    sw.Start();
        //    using (TransactionScope tsc = new TransactionScope())
        //    {
        //        TestDBUpdate(connectString1, connectString2, commandText1, commandText2);
        //        tsc.Complete();
        //    }
        //    sw.Stop();
        //    txtMSDTC.Text = sw.ElapsedMilliseconds.ToString();
        //}

       

        private void btnSample_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            TestDBUpdate(connectString1, connectString2, commandText1, commandText2);
            sw.Stop();
            txtSample.Text = sw.ElapsedMilliseconds.ToString();
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            using (TransactionScope tsc = new TransactionScope())
            {
                TestDBUpdate(connectString1, connectString1, commandText1, commandText2);
                tsc.Complete();
            }
            sw.Stop();
            txtTrans.Text = sw.ElapsedMilliseconds.ToString();
        
        }

        private void TestDBUpdate(string connectString1, string connectString2, string commandText1, string commandText2)
        {
            int returnValue;
            using (SqlConnection connection1 = new SqlConnection(connectString1))
            {
                connection1.Open();

                // Create the SqlCommand object and execute the first command.
                SqlCommand command1 = new SqlCommand(commandText1, connection1);
                returnValue = command1.ExecuteNonQuery();
                //writer.WriteLine("Rows to be affected by command1: {0}", returnValue);

                // If you get here, this means that command1 succeeded. By nesting
                // the using block for connection2 inside that of connection1, you
                // conserve server and network resources as connection2 is opened
                // only when there is a chance that the transaction can commit.   
                using (SqlConnection connection2 = new SqlConnection(connectString2))
                {
                    // The transaction is escalated to a full distributed
                    // transaction when connection2 is opened.
                    connection2.Open();

                    // Execute the second command in the second database.
                    returnValue = 0;
                    SqlCommand command2 = new SqlCommand(commandText2, connection2);
                    returnValue = command2.ExecuteNonQuery();
                    //writer.WriteLine("Rows to be affected by command2: {0}", returnValue);
                }
            }
        }
    }
}
