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
    public partial class frmTimHoadon_Nhanvien : Form
    {
        public frmTimHoadon_Nhanvien()
        {
            InitializeComponent();
        }

        private void frmTimHoadon_Nhanvien_Load(object sender, EventArgs e)
        {
            LoadDL_MaNV();
            SetTextBox(false);
        }
        private void SetTextBox(bool a)
        {
            txtHotennv.Enabled = a;
            txtPhai.Enabled = a;
            dtpNgaysinh.Enabled = a;
            txtHesoluong.Enabled = a;
            txtHesochucvu.Enabled = a;
            txtMaphong.Enabled = a;
        }
        private void LoadDL_MaNV()
        {
            try
            {
                string sql = "select MANV from NHANVIEN";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, DataBase.SqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbManv.DataSource = dt;
                cbManv.DisplayMember = "MANV";
                cbManv.ValueMember = "MANV";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LayDL_NhanVien()
        {
            try
            {
                if (DataBase.SqlConnection.State == ConnectionState.Open) DataBase.SqlConnection.Close();
                DataBase.SqlConnection.Open();
                string sql = @"select HOTEN, (CASE WHEN PHAI = 1 THEN N'Nam' ELSE N'Nữ' END) as PHAI, NGAYSINH, HSLUONG, HSCHUCVU, MAPHONG
                            from NHANVIEN where MANV = @manv";
                SqlCommand cmd = new SqlCommand(sql, DataBase.SqlConnection);
                cmd.Parameters.AddWithValue("@manv", cbManv.SelectedValue.ToString());
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    if (!rd.IsDBNull(0))
                    {
                        txtHotennv.Text = rd.GetString(0);
                    }
                    else
                    {
                        txtHotennv.Text = "";
                    }
                    if (!rd.IsDBNull(1))
                    {
                        txtPhai.Text = rd.GetString(1);
                    }
                    else
                    {
                        txtPhai.Text = "";
                    }
                    if (!rd.IsDBNull(2))
                    {
                        dtpNgaysinh.Value = rd.GetDateTime(2);
                    }
                    else
                    {
                        dtpNgaysinh.Text = "";
                    }
                    if (!rd.IsDBNull(3))
                    {
                        txtHesoluong.Text = rd.GetDouble(3).ToString();
                    }
                    else
                    {
                        txtHesoluong.Text = "";
                    }
                    if (!rd.IsDBNull(4))
                    {
                        txtHesochucvu.Text = rd.GetDouble(4).ToString();
                    }
                    else
                    {
                        txtHesochucvu.Text = "";
                    }
                    if (!rd.IsDBNull(5))
                    {
                        txtMaphong.Text = rd.GetString(5);
                    }
                    else
                    {
                        txtMaphong.Text = "";
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
        private void LoadDGV_HoaDon()
        {
            try
            {
                string sql = @"SELECT HOADON.SOHD, KHACHHANG, DIACHI, DIENTHOAI, NGAYHD, SUM(HANGHOA.DONGIA * CTHOADON.SOLUONG) AS TongTien
                                FROM HOADON INNER JOIN CTHOADON ON CTHOADON.SOHD = HOADON.SOHD
                                INNER JOIN HANGHOA ON CTHOADON.MAHANG = HANGHOA.MAHANG
                                where MANV = '" + cbManv.Text + "' GROUP BY HOADON.SOHD, KHACHHANG, DIACHI, DIENTHOAI, NGAYHD";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, DataBase.SqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvHoadon.DataSource = dt;
                dgvHoadon.Columns[0].HeaderText = "Số hóa đơn";
                dgvHoadon.Columns[1].HeaderText = "Khách hàng";
                dgvHoadon.Columns[2].HeaderText = "Địa chỉ";
                dgvHoadon.Columns[3].HeaderText = "Điện thoại";
                dgvHoadon.Columns[4].HeaderText = "Ngày lập hóa đơn";
                dgvHoadon.Columns[5].HeaderText = "Thành tiền";
                dgvHoadon.AllowUserToAddRows = false;
                dgvHoadon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvHoadon.EditMode = DataGridViewEditMode.EditProgrammatically;
                dgvHoadon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            LayDL_NhanVien();
            LoadDGV_HoaDon();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
