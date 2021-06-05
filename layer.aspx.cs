using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace bt_test_load
{
    public partial class layer : System.Web.UI.Page
    {
        string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\KTTMDT\BTTH\bt_test_load\bt_test_load\App_Data\Database1.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string username = this.Login1.UserName;
            string password = this.Login1.Password;
            string sql = "Select *From KhachHang Where TenDN='" + username + "' and MatKhau='" + password + "'";
            DataTable table = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, link);
                da.Fill(table);
            }
            catch (SqlException err)
            {
                Response.Write("<b>Error</b>" + err.Message + "<p/>");
            }
            if (table.Rows.Count != 0)
            {
                Response.Cookies["TenDN"].Value = username;
                Server.Transfer("");
            }
            else
            {
                this.Login1.FailureText = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
        }
    }
}