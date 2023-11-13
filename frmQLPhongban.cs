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
    public partial class frmQLPhongban : Form
    {
        public frmQLPhongban()
        {
            InitializeComponent();
        }

        private void frmQLPhongban_Load(object sender, EventArgs e)
        {
            LoadDL_PhongBan();
            SetTextBox(false);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void SetTextBox(bool a)
        {
            txtMaphong.Enabled = a;
            txtTenphong.Enabled = a;
            txtSdt.Enabled = a;
        }

        private void LoadDL_PhongBan()
        {
            string sql = "select * from PHONGBAN";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DataBase.SqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvPhongban.DataSource = dt;
            dgvPhongban.Columns[0].HeaderText = "Mã Phòng Ban";
            dgvPhongban.Columns[1].HeaderText = "Tên Phòng Ban";
            dgvPhongban.Columns[2].HeaderText = "Số điện thoại";
            dgvPhongban.AllowUserToAddRows = false;
            dgvPhongban.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhongban.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPhongban.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvPhongban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                txtMaphong.Text = dgvPhongban.Rows[dong].Cells[0].Value.ToString();
                txtTenphong.Text = dgvPhongban.Rows[dong].Cells[1].Value.ToString();
                txtSdt.Text = dgvPhongban.Rows[dong].Cells[2].Value.ToString();
            }
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaphong.Clear();
            txtTenphong.Clear();
            txtSdt.Clear();
            SetTextBox(true);
            btnLuu.Enabled = true;
        }

        bool capnhat = false;

        private void btnSua_Click(object sender, EventArgs e)
        {
            capnhat = true;
            SetTextBox(true);
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.SqlConnection.State == ConnectionState.Open)
                    DataBase.SqlConnection.Close();
                DataBase.SqlConnection.Open();

                string sql = "select count(*) from PHONGBAN where MAPHONG = '" + txtMaphong.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, DataBase.SqlConnection);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Đã có mã phòng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (capnhat == true)
                    {
                        int dong = dgvPhongban.CurrentRow.Index;
                        string maphong = dgvPhongban.Rows[dong].Cells[0].Value.ToString();
                        string sqlupdate = @"update PHONGBAN set 
                                            MAPHONG = @maphong, TENPHONG = @tenphong, DIENTHOAI = @sdt
                                            WHERE MAPHONG = '" + maphong + "'";
                        SqlCommand cmd1 = new SqlCommand(sqlupdate, DataBase.SqlConnection);
                        cmd1.Parameters.AddWithValue("@maphong", txtMaphong.Text);
                        cmd1.Parameters.AddWithValue("@tenphong", txtTenphong.Text);
                        cmd1.Parameters.AddWithValue("@sdt", txtSdt.Text);
                        cmd1.ExecuteNonQuery();
                        cmd1.Dispose();
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDL_PhongBan();
                        capnhat = false;
                    }
                    else
                    {
                        string sqlinsert = @"insert into PHONGBAN (MAPHONG, TENPHONG, DIENTHOAI)
                                            values (@maphong, @tenphong, @sdt)";
                        SqlCommand cmd1 = new SqlCommand(sqlinsert, DataBase.SqlConnection);
                        cmd1.Parameters.AddWithValue("@maphong", txtMaphong.Text);
                        cmd1.Parameters.AddWithValue("@tenphong", txtTenphong.Text);
                        cmd1.Parameters.AddWithValue("@sdt", txtSdt.Text);
                        cmd1.ExecuteNonQuery();
                        cmd1.Dispose();
                        MessageBox.Show("Đã lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDL_PhongBan();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                SetTextBox(false);
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

                foreach (DataGridViewRow selectedRow in dgvPhongban.SelectedRows)
                {
                    string maphong = selectedRow.Cells["MAPHONG"].Value.ToString();
                    string sqlDelete = "delete PHONGBAN WHERE MAPHONG = @maphong";
                    SqlCommand cmd = new SqlCommand(sqlDelete, DataBase.SqlConnection);
                    cmd.Parameters.AddWithValue("@maphong", maphong);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }

                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDL_PhongBan();
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
