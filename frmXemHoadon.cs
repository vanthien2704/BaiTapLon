using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaiTapLon
{
    public partial class frmXemHoadon : Form
    {
        public frmXemHoadon()
        {
            InitializeComponent();
        }
        private void LoadDL_SoHD()
        {
            string sql = "select SOHD from HOADON";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DataBase.SqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbSohd.DataSource = dt;
            cbSohd.DisplayMember = "SOHD";
            cbSohd.ValueMember = "SOHD";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.SqlConnection.State == ConnectionState.Open) DataBase.SqlConnection.Close();
                DataBase.SqlConnection.Open();
                string sql = @"SELECT HOADON.SOHD, HOADON.KHACHHANG, HOADON.DIACHI, HOADON.DIENTHOAI, CONVERT(VARCHAR, CONVERT(DATE, HOADON.NGAYHD, 103), 103)as NGAYHD, HANGHOA.MAHANG, HANGHOA.TENHANG, CONVERT(VARCHAR, CONVERT(DATE, HANGHOA.NGAYSX, 103), 103)as NGAYSX, HANGHOA.DONGIA, CTHOADON.SOLUONG, (HANGHOA.DONGIA*CTHOADON.SOLUONG) as THANHTIEN
                                FROM CTHOADON INNER JOIN
                                HANGHOA ON CTHOADON.MAHANG = HANGHOA.MAHANG INNER JOIN
                                HOADON ON CTHOADON.SOHD = HOADON.SOHD
                            where HOADON.SOHD ='" + cbSohd.Text + "' ";
                SqlDataAdapter Adapter = new SqlDataAdapter(sql, DataBase.SqlConnection);
                DataTable DT = new DataTable();
                Adapter.Fill(DT);
                RPHoaDon RPHD = new RPHoaDon();
                RPHD.SetDataSource(DT);
                CRHoaDon.ReportSource = RPHD;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DataBase.SqlConnection.Close();
            }
        }

        private void frmXemHoadon_Load(object sender, EventArgs e)
        {
            LoadDL_SoHD();
        }
    }
}
