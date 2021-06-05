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
    public partial class Sanpham : System.Web.UI.Page
    {
        //string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\KTTMDT\BTTH\bt_test_load\bt_test_load\App_Data\Database1.mdf;Integrated Security=True";
        xuly KN = new xuly();
        protected void Page_Load(object sender, EventArgs e)
        {
            loadsp();
        }
        public void loadsp()
        {
            if (Page.IsPostBack) return;
            string sql;
            if (Context.Items["ML"] == null) { sql = "Select *From SanPham"; }
            else
            {
                String MaLoai = Context.Items["ML"].ToString();
                sql = "Select *From SanPham where MaLoai='" + MaLoai + "'";
            }
            try
            {
                /*SqlDataAdapter da = new SqlDataAdapter(sql, link);
                DataTable dt = new DataTable();
                da.Fill(dt);*/
                this.DataList2.DataSource = KN.loadData(sql);
                this.DataList2.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex);
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            string mahang = ((LinkButton)sender).CommandArgument;
            Context.Items["MH"] = mahang;
            Server.Transfer("chitiet.aspx");
        }
    }
}