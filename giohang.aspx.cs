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
    public partial class giohang : System.Web.UI.Page
    {
        string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\KTTMDT\BTTH\bt_test_load\bt_test_load\App_Data\Database1.mdf;Integrated Security=True";
        xuly KN = new xuly();
        protected void Page_Load(object sender, EventArgs e)
        {
            load_giohang();
            //try
            //{
            //    string sql = "Select DonHang.MaSP, TenSP, Gia, Soluong,"
            //        + "Soluong*Gia as thanhtien From DonHang, SanPham" + "Where SanPham.MaSP=DonHang.MaSP";
            //    //GridView1.DataSource = KN.loadData(sql);
            //    SqlDataAdapter da = new SqlDataAdapter(sql, link);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    this.GridView1.DataSource = dt;
            //    this.GridView1.DataBind();
            //    double Tong = 0;
            //    foreach (DataRow row in dt.Rows)
            //    {
            //        double thanhtien = Convert.ToDouble(row["thanhtien"]);
            //        Tong = Tong + thanhtien;
            //    }
            //    this.Label1.Text = "Tổng thành tiền: " + Tong + "đồng";
            //}
            //catch (SqlException ex)
            //{
            //    Response.Write(ex.Message);
            //}
        }
        public void load_giohang()
        {
            try
            {
                string q = "select DonHang.MaSP,TenSP,Gia,Soluong,"
                    + "Soluong*Gia as thanhtien from DonHang,SanPham " + " where SanPham.MaSP = DonHang.MaSP";
                SqlDataAdapter da = new SqlDataAdapter(q, link);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.GridView1.DataSource = dt;
                this.GridView1.DataBind();
                //Tính tổng thành tiền: duyệt dataTable
                double tong = 0;
                foreach (DataRow row in dt.Rows)
                {
                    double thanhtien = Convert.ToDouble(row["thanhtien"]);
                    tong = tong + thanhtien;
                }
                this.Label1.Text = "Tổng thành tiền: " + tong + " đồng";
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}