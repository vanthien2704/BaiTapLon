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
    public partial class frmTimkiemHoadon : Form
    {
        public frmTimkiemHoadon()
        {
            InitializeComponent();
        }

        private void frmTimkiemHoadon_Load(object sender, EventArgs e)
        {
            LoadDL_MaHD();
            SetTextBox(false);
        }
        private void LoadDL_MaHD()
        {
            try
            {
                string sql = "select SOHD from HOADON";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, DataBase.SqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbMahoadon.DataSource = dt;
                cbMahoadon.DisplayMember = "SOHD";
                cbMahoadon.ValueMember = "SOHD";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LayDL_HoaDon()
        {
            try
            {
                if (DataBase.SqlConnection.State == ConnectionState.Open) DataBase.SqlConnection.Close();
                DataBase.SqlConnection.Open();
                string sql = @"select KHACHHANG, DIACHI, DIENTHOAI, NGAYHD
                            from HOADON where SOHD = @sohd";
                SqlCommand cmd = new SqlCommand(sql, DataBase.SqlConnection);
                cmd.Parameters.AddWithValue("@sohd", cbMahoadon.SelectedValue.ToString());
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    if (!rd.IsDBNull(0))
                    {
                        txtKhachhang.Text = rd.GetString(0);
                    }
                    else
                    {
                        txtKhachhang.Text = "";
                    }
                    if (!rd.IsDBNull(1))
                    {
                        txtDiachi.Text = rd.GetString(1);
                    }
                    else
                    {
                        txtDiachi.Text = "";
                    }
                    if (!rd.IsDBNull(2))
                    {
                        txtDienthoai.Text = rd.GetString(2);
                    }
                    else
                    {
                        txtDienthoai.Text = "";
                    }
                    if (!rd.IsDBNull(3))
                    {
                        dtpNgaylap.Value = rd.GetDateTime(3);
                    }
                    else
                    {
                        dtpNgaylap.Text = "";
                    }
                }
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
        private void SetTextBox(bool a)
        {
            txtKhachhang.Enabled = a;
            txtDiachi.Enabled = a;
            txtDienthoai.Enabled = a;
            dtpNgaylap.Enabled = a;
        }
        private void LoadDGV_CTHoaDon()
        {
            try
            {
                string sql = @"select CTHOADON.MAHANG, TENHANG, SOLUONG, DONGIA, (SOLUONG*DONGIA) as THANHTIEN 
                                from HANGHOA INNER JOIN CTHOADON on HANGHOA.MAHANG = CTHOADON.MAHANG
                                where SOHD = '" + cbMahoadon.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, DataBase.SqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvHanghoa.DataSource = dt;
                dgvHanghoa.Columns[0].HeaderText = "Mã hàng";
                dgvHanghoa.Columns[1].HeaderText = "Tên hàng";
                dgvHanghoa.Columns[2].HeaderText = "Số lượng";
                dgvHanghoa.Columns[3].HeaderText = "Đơn giá";
                dgvHanghoa.Columns[4].HeaderText = "Thành tiền";
                dgvHanghoa.AllowUserToAddRows = false;
                dgvHanghoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvHanghoa.EditMode = DataGridViewEditMode.EditProgrammatically;
                dgvHanghoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                TongTienHD();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TongTienHD()
        {
            decimal tongtien = 0;
            foreach (DataGridViewRow row in dgvHanghoa.Rows)
            {
                decimal tien = Convert.ToDecimal(row.Cells[4].Value);
                tongtien += tien;
            }
            txtGiatriHD.Text = tongtien.ToString();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            LayDL_HoaDon();
            LoadDGV_CTHoaDon();
        }
    }
}
