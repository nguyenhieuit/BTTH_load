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
    public partial class start : System.Web.UI.MasterPage
    {
        //string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\KTTMDT\BTTH\bt_test_load\bt_test_load\App_Data\Database1.mdf;Integrated Security=True";
        xuly KN = new xuly();
        protected void Page_Load(object sender, EventArgs e)
        {
            load_LoaiSP();
        }
        public void load_LoaiSP()
        {
            string sql = "Select *From LoaiSP";
            //SqlDataAdapter da = new SqlDataAdapter(sql, link);
            //DataTable dt = new DataTable();
            //da.Fill(dt)
            DataList1.DataSource = KN.loadData(sql);
            this.DataList1.DataBind();
        }
        /*protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
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
                Server.Transfer("Trangchu.aspx");
            }
            else
            {
                this.Login1.FailureText = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
        }*/

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            String MaLoai = ((LinkButton)sender).CommandArgument;
            Context.Items["ML"] = MaLoai;
            Server.Transfer("Sanpham.aspx");
        }
    }
}