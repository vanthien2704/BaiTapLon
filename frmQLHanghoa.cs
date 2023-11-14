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
    public partial class frmQLHanghoa : Form
    {
        public frmQLHanghoa()
        {
            InitializeComponent();
        }

        private void frmQLHanghoa_Load(object sender, EventArgs e)
        {
            LoadDL_HangHoa();
            SetTextBox(false);
            SetButtons("Luu");
        }
        private void LoadDL_HangHoa()
        {
            try
            {
                string sql = "select * from HANGHOA";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, DataBase.SqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvHanghoa.DataSource = dt;
                dgvHanghoa.Columns[0].HeaderText = "Mã Hàng";
                dgvHanghoa.Columns[1].HeaderText = "Tên Hàng";
                dgvHanghoa.Columns[2].HeaderText = "Ngày sản xuất";
                dgvHanghoa.Columns[3].HeaderText = "Đơn giá";
                dgvHanghoa.AllowUserToAddRows = false;
                dgvHanghoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvHanghoa.EditMode = DataGridViewEditMode.EditProgrammatically;
                dgvHanghoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetTextBox(bool a)
        {
            txtMahang.Enabled = a;
            txtTenhang.Enabled = a;
            txtDongia.Enabled = a;
            dtpNgaysx.Enabled = a;
        }
        private void SetButtons(string mode)
        {
            switch (mode)
            {
                case "Them":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnLuu.Enabled = true;
                    btnXoa.Enabled = false;
                    break;

                case "Sua":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnLuu.Enabled = true;
                    btnXoa.Enabled = false;
                    break;

                case "Luu":
                    btnThem.Enabled = true;
                    btnSua.Enabled = false;
                    btnLuu.Enabled = false;
                    btnXoa.Enabled = false;
                    break;
                case "CellClick":
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    break;
            }
        }

        private void dgvHanghoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                txtMahang.Text = dgvHanghoa.Rows[dong].Cells[0].Value.ToString();
                txtTenhang.Text = dgvHanghoa.Rows[dong].Cells[1].Value.ToString();
                dtpNgaysx.Text = dgvHanghoa.Rows[dong].Cells[2].Value.ToString();
                txtDongia.Text = dgvHanghoa.Rows[dong].Cells[3].Value.ToString();
            }
            SetButtons("CellClick");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMahang.Clear();
            txtTenhang.Clear();
            txtDongia.Clear();
            dtpNgaysx.ResetText();
            SetTextBox(true);
            SetButtons("Them");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.SqlConnection.State == ConnectionState.Open)
                    DataBase.SqlConnection.Close();
                DataBase.SqlConnection.Open();

                string sql = "select count(*) from HANGHOA where MAHANG = '" + txtMahang.Text + "'";
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
                        int dong = dgvHanghoa.CurrentRow.Index;
                        string mahang = dgvHanghoa.Rows[dong].Cells[0].Value.ToString();
                        string sqlupdate = @"update HANGHOA set 
                                            MAHANG = @mahang, TENHANG = @tenhang, DONGIA = @dongia, NGAYSX = @ngaysx
                                            WHERE MAHANG = '" + mahang + "'";
                        SqlCommand cmd1 = new SqlCommand(sqlupdate, DataBase.SqlConnection);
                        cmd1.Parameters.AddWithValue("@mahang", txtMahang.Text);
                        cmd1.Parameters.AddWithValue("@tenhang", txtTenhang.Text);
                        cmd1.Parameters.AddWithValue("@dongia", txtDongia.Text);
                        cmd1.Parameters.AddWithValue("@ngaysx", dtpNgaysx.Text);
                        cmd1.ExecuteNonQuery();
                        cmd1.Dispose();
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDL_HangHoa();
                        SetButtons("Luu");
                        SetTextBox(false);
                        capnhat = false;
                    }
                    else
                    {
                        string sqlinsert = @"insert into HANGHOA (MAHANG, TENHANG, DONGIA, NGAYSX)
                                            values (@mahang, @tenhang, @dongia, @ngaysx)";
                        SqlCommand cmd1 = new SqlCommand(sqlinsert, DataBase.SqlConnection);
                        cmd1.Parameters.AddWithValue("@mahang", txtMahang.Text);
                        cmd1.Parameters.AddWithValue("@tenhang", txtTenhang.Text);
                        cmd1.Parameters.AddWithValue("@dongia", txtDongia.Text);
                        cmd1.Parameters.AddWithValue("@ngaysx", dtpNgaysx.Text);
                        cmd1.ExecuteNonQuery();
                        cmd1.Dispose();
                        MessageBox.Show("Đã lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDL_HangHoa();
                        SetButtons("Luu");
                        SetTextBox(false);
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
        bool capnhat = false;
        private void btnSua_Click(object sender, EventArgs e)
        {
            capnhat = true;
            SetTextBox(true);
            SetButtons("Sua");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.SqlConnection.State == ConnectionState.Open)
                    DataBase.SqlConnection.Close();
                DataBase.SqlConnection.Open();

                foreach (DataGridViewRow selectedRow in dgvHanghoa.SelectedRows)
                {
                    string mahang = selectedRow.Cells["MAHANG"].Value.ToString();
                    string sqlDelete = "delete HANGHOA WHERE MAHANG = @mahang";
                    SqlCommand cmd = new SqlCommand(sqlDelete, DataBase.SqlConnection);
                    cmd.Parameters.AddWithValue("@mahang", mahang);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDL_HangHoa();
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
