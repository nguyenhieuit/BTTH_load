using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace bt_test_load
{

    public class xuly
    {
        SqlConnection cnn;
        private void openKN()
        {
            cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\KTTMDT\BTTH\bt_test_load\bt_test_load\App_Data\Database1.mdf;Integrated Security=True");
            cnn.Open();
        }
        private void closeKN()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
        public DataTable loadData( string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                openKN();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, cnn);
                dataAdapter.Fill(dt);
            }
            catch
            {
                dt = null;
            }
            finally
            {
                closeKN();
            }
            return dt;
        }
    }
}