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
using System.Globalization;

namespace BaiTapLon
{
    public partial class frmQLNhanvien : Form
    {
        public frmQLNhanvien()
        {
            InitializeComponent();
        }

        private void frmQLNhanvien_Load(object sender, EventArgs e)
        {
            LoadDL_NhanVien();
            SetTextBox(false);
            SetButtons("Luu");
        }
        private void LoadDL_NhanVien()
        {
            try
            {
                string sql = @"select MANV, HOTEN, (CASE WHEN PHAI = 1 THEN N'Nam' ELSE N'Nữ' END) as PHAI,
                                 NGAYSINH, HSLUONG, HSCHUCVU, CAST((HSLUONG+HSCHUCVU)*1300000 AS INT) AS LUONG, MAPHONG from NHANVIEN";
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
                dgvNhanvien.Columns[7].HeaderText = "Mã phòng";
                dgvNhanvien.AllowUserToAddRows = false;
                dgvNhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvNhanvien.EditMode = DataGridViewEditMode.EditProgrammatically;
                dgvNhanvien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                txtManv.Text = dgvNhanvien.Rows[dong].Cells[0].Value.ToString();
                txtHotennv.Text = dgvNhanvien.Rows[dong].Cells[1].Value.ToString();
                txtPhai.Text = dgvNhanvien.Rows[dong].Cells[2].Value.ToString();
                dtpNgaysinh.Text= dgvNhanvien.Rows[dong].Cells[3].Value.ToString();
                txtHesoluong.Text = dgvNhanvien.Rows[dong].Cells[4].Value.ToString();
                txtHesochucvu.Text = dgvNhanvien.Rows[dong].Cells[5].Value.ToString();
                txtTienluong.Text = dgvNhanvien.Rows[dong].Cells[6].Value.ToString();
                SetButtons("CellClick");
            }
        }
        private void SetTextBox(bool a)
        {
            txtManv.Enabled = a;
            dtpNgaysinh.Enabled = a;
            txtHesoluong.Enabled = a;
            txtTienluong.Enabled = a;
            txtHotennv.Enabled = a;
            txtPhai.Enabled = a;
            txtHesochucvu.Enabled = a;
        }
        private void SetButtons(string mode)
        {
            switch (mode)
            {
                case "Load":
                    btnThem.Enabled = true;
                    btnLuumoi.Enabled = false;
                    btnSua.Enabled = false;
                    btnLuusua.Enabled = false;
                    btnXoa.Enabled = false;
                    break;
                case "Them":
                    btnThem.Enabled = false;
                    btnLuumoi.Enabled = true;
                    btnSua.Enabled = false;
                    btnLuusua.Enabled = false;
                    btnXoa.Enabled = false;
                    break;

                case "Sua":
                    btnThem.Enabled = false;
                    btnLuumoi.Enabled = false;
                    btnSua.Enabled = false;
                    btnLuusua.Enabled = true;
                    btnXoa.Enabled = false;
                    break;

                case "Luu":
                    btnThem.Enabled = true;
                    btnLuumoi.Enabled = false;
                    btnSua.Enabled = false;
                    btnLuusua.Enabled = false;
                    btnXoa.Enabled = false;
                    break;
                case "CellClick":
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    break;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtManv.Clear();
            dtpNgaysinh.ResetText();
            txtHesoluong.Clear();
            txtTienluong.Clear();
            txtHotennv.Clear();
            txtPhai.Clear();
            txtHesochucvu.Clear();
            SetTextBox(true);
            SetButtons("Them");
        }

        private void btnLuumoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.SqlConnection.State == ConnectionState.Open)
                    DataBase.SqlConnection.Close();
                DataBase.SqlConnection.Open();

                string sql = "select count(*) from NHANVIEN where MANV = '" + txtManv.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, DataBase.SqlConnection);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Đã có mã phòng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string sqlinsert = @"insert into NHANVIEN (MANV, HOTEN, PHAI, NGAYSINH, HSLUONG, HSCHUCVU)
                                            values (@manv, @hoten, @phai, @ngaysinh, @hesoluong, @hesochucvu)";
                    SqlCommand cmd1 = new SqlCommand(sqlinsert, DataBase.SqlConnection);
                    cmd1.Parameters.AddWithValue("@manv", txtManv.Text);
                    cmd1.Parameters.AddWithValue("@ngaysinh", dtpNgaysinh.Value);
                    cmd1.Parameters.AddWithValue("@hesoluong", txtHesoluong.Text);
                    cmd1.Parameters.AddWithValue("@hoten", txtHotennv.Text);
                    cmd1.Parameters.AddWithValue("@phai", txtPhai.Text.ToLower() == "nam" ? 1 : 0);
                    cmd1.Parameters.AddWithValue("@hesochucvu", txtHesochucvu.Text);
                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();
                    MessageBox.Show("Đã lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDL_NhanVien();
                    SetButtons("Luu");
                    SetTextBox(false);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            SetTextBox(true);
            SetButtons("Sua");
        }

        private void btnLuusua_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.SqlConnection.State == ConnectionState.Open)
                    DataBase.SqlConnection.Close();
                DataBase.SqlConnection.Open();

                string sql = "select count(*) from NHANVIEN where MANV = '" + txtManv.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, DataBase.SqlConnection);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Đã có mã phòng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int dong = dgvNhanvien.CurrentRow.Index;
                    string manv = dgvNhanvien.Rows[dong].Cells[0].Value.ToString();
                    string sqlupdate = @"update NHANVIEN set 
                                            MANV = @manv, HOTEN = @hoten, PHAI = @phai, NGAYSINH = @ngaysinh, HSLUONG = @hesoluong, HSCHUCVU = @hesochucvu
                                            WHERE MANV = '" + manv + "'";
                    SqlCommand cmd1 = new SqlCommand(sqlupdate, DataBase.SqlConnection);
                    cmd1.Parameters.AddWithValue("@manv", txtManv.Text);
                    cmd1.Parameters.AddWithValue("@ngaysinh", dtpNgaysinh.Value);
                    cmd1.Parameters.AddWithValue("@hesoluong", txtHesoluong.Text);
                    cmd1.Parameters.AddWithValue("@hoten", txtHotennv.Text);
                    cmd1.Parameters.AddWithValue("@phai", txtPhai.Text.ToLower() == "nam" ? 1 : 0);
                    cmd1.Parameters.AddWithValue("@hesochucvu", txtHesochucvu.Text);
                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDL_NhanVien();
                    SetButtons("Luu");
                    SetTextBox(false);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.SqlConnection.State == ConnectionState.Open)
                    DataBase.SqlConnection.Close();
                DataBase.SqlConnection.Open();

                foreach (DataGridViewRow selectedRow in dgvNhanvien.SelectedRows)
                {
                    string manv = selectedRow.Cells["MANV"].Value.ToString();
                    string sqlDelete = "delete NHANVIEN WHERE MANV = @manv";
                    SqlCommand cmd = new SqlCommand(sqlDelete, DataBase.SqlConnection);
                    cmd.Parameters.AddWithValue("@manv", manv);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDL_NhanVien();
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
