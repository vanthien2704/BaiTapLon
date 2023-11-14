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
    public partial class frmTKNhanvien_Phong : Form
    {
        public frmTKNhanvien_Phong()
        {
            InitializeComponent();
        }

        private void frmTKNhanvien_Phong_Load(object sender, EventArgs e)
        {
            LoadDL_Maphong();
            LoadDL_NhanVien();
            txtTenphong.ReadOnly = true;
            txtSdt.ReadOnly = true;
            txtSonv.ReadOnly = true;
            txtTongtienluong.ReadOnly = true;
        }
        private void LoadDL_NhanVien()
        {
            try
            {
                string sql = @"select MANV, HOTEN, (CASE WHEN PHAI = 1 THEN N'Nam' ELSE N'Nữ' END) as PHAI,
                                 NGAYSINH, HSLUONG, HSCHUCVU, ((HSLUONG+HSCHUCVU)*1300000) as LUONG from NHANVIEN";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, DataBase.SqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvNhanvien.DataSource = dt;
                dgvNhanvien.Columns[0].HeaderText = "Mã Nhân Viên";
                dgvNhanvien.Columns[1].HeaderText = "Họ và Tên";
                dgvNhanvien.Columns[2].HeaderText = "Phái";
                dgvNhanvien.Columns[3].HeaderText = "Ngày sinh";
                dgvNhanvien.Columns[4].HeaderText = "Hệ số lương";
                dgvNhanvien.Columns[5].HeaderText = "Hệ số chức vụ";
                dgvNhanvien.Columns[6].HeaderText = "Tiền lương";
                dgvNhanvien.AllowUserToAddRows = false;
                dgvNhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvNhanvien.EditMode = DataGridViewEditMode.EditProgrammatically;
                dgvNhanvien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DemSoNV();
                TinhTongLuong();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDL_Maphong()
        {
            try
            {
                string sql = "select MAPHONG from PHONGBAN";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, DataBase.SqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbMaphong.DataSource = dt;
                cbMaphong.DisplayMember = "MAPHONG";
                cbMaphong.ValueMember = "MAPHONG";
                //Gợi ý khi nhập cbMaphong
                cbMaphong.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbMaphong.AutoCompleteSource = AutoCompleteSource.ListItems;
                LayDL_PhongBan();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LayDL_PhongBan()
        {
            try
            {
                if (DataBase.SqlConnection.State == ConnectionState.Open) DataBase.SqlConnection.Close();
                DataBase.SqlConnection.Open();
                string sql = @"select TENPHONG, DIENTHOAI
                            from PHONGBAN where MAPHONG = @maphong";
                SqlCommand cmd = new SqlCommand(sql, DataBase.SqlConnection);
                cmd.Parameters.AddWithValue("@maphong", cbMaphong.SelectedValue.ToString());
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    if (!rd.IsDBNull(0))
                    {
                        txtTenphong.Text = rd.GetString(0);
                    }
                    else
                    {
                        txtTenphong.Text = "";
                    }
                    if (!rd.IsDBNull(1))
                    {
                        txtSdt.Text = rd.GetString(1);
                    }
                    else
                    {
                        txtSdt.Text = "";
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

        private void cbMaphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayDL_PhongBan();
            try
            {
                string sql = @"select MANV, HOTEN, (CASE WHEN PHAI = 1 THEN N'Nam' ELSE N'Nữ' END) as PHAI,
                                 NGAYSINH, HSLUONG, HSCHUCVU, ((HSLUONG+HSCHUCVU)*1300000) as LUONG from NHANVIEN
                                 where MAPHONG = '"+cbMaphong.Text+"'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, DataBase.SqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvNhanvien.DataSource = dt;
                DemSoNV();
                TinhTongLuong();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
        private void DemSoNV()
        {
            int count = dgvNhanvien.RowCount;
            txtSonv.Text = count.ToString();
        }
        private void TinhTongLuong()
        {
            decimal tongLuong = 0;
            foreach (DataGridViewRow row in dgvNhanvien.Rows)
            {
                decimal luong = Convert.ToDecimal(row.Cells[6].Value);
                tongLuong += luong;
            }
            txtTongtienluong.Text = tongLuong.ToString();
        }
    }
}
