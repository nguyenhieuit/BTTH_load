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
    public partial class chitiet : System.Web.UI.Page
    {
        string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\KTTMDT\BTTH\bt_test_load\bt_test_load\App_Data\Database1.mdf;Integrated Security=True";
        xuly KN = new xuly();
        protected void Page_Load(object sender, EventArgs e)
        {
            load_ctsp();
        }
        public void load_ctsp()
        {
            if (Page.IsPostBack) return;
            string sql;
            if (Context.Items["MH"] == null)
            {
                sql = "Select *From SanPham";
            }
            else
            {
                string mahang = Context.Items["MH"].ToString();
                sql = "Select *From SanPham Where MaSP='" + mahang + "'";
            }
            try
            {
                /*SqlDataAdapter da = new SqlDataAdapter(sql,link);
                DataTable dt = new DataTable();
                da.Fill(dt);*/
                this.DataList1.DataSource = KN.loadData(sql);
                this.DataList1.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Server.Transfer("giohang.aspx");
        }

        protected void btn_muahang_Click(object sender, EventArgs e)
        {
            Button muahang = ((Button)sender);
            string mahang = muahang.CommandArgument.ToString();
            DataListItem item = (DataListItem)muahang.Parent;
            string SL = ((TextBox)item.FindControl("txt_SL")).Text;
            if (Request.Cookies["TenDN"] == null) return; //Kiểm tra đăng nhập
            string tendn = Request.Cookies["TenDN"].Value;
            SqlConnection cnn = new SqlConnection(link);
            cnn.Open();
            string sql = "Select *From DonHang " + "Where TenDN='" + tendn + "' and MaSP='" + mahang + "'";
            SqlCommand cmm = new SqlCommand(sql, cnn);
            SqlDataReader read = cmm.ExecuteReader();
            if (read.Read())
            {
                read.Close();
                cmm = new SqlCommand("Update DonHang set Soluong = Soluong + " + SL + " Where TenDN='" + tendn + "' AND MaSP='" + mahang + "'", cnn);
            }
            else
            {
                read.Close();
                cmm = new SqlCommand("Insert into DonHang" + "(TenDN, MaSP, Soluong) values('" + tendn + "', '" + mahang + "', '" + SL + "')", cnn);
            }
            cmm.ExecuteNonQuery();
            cnn.Close();
        }
    }
}