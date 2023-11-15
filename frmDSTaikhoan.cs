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
    public partial class frmDSTaikhoan : Form
    {
        public frmDSTaikhoan()
        {
            InitializeComponent();
        }

        private void frmDSTaikhoan_Load(object sender, EventArgs e)
        {
            LoadDGV_TaiKhoan();
        }
        private void LoadDGV_TaiKhoan()
        {
            try
            {
                string sql = @"select ID_USER, TENTK, QUYEN from TAIKHOAN";
                SqlDataAdapter ad = new SqlDataAdapter(sql, DataBase.SqlConnection);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dgvDSTK.DataSource = dt;
                dgvDSTK.DataSource = dt;
                dgvDSTK.Columns[0].HeaderText = "ID USER";
                dgvDSTK.Columns[1].HeaderText = "Tên tài khoản";
                dgvDSTK.Columns[2].HeaderText = "Quyền";
                dgvDSTK.AllowUserToAddRows = false;
                dgvDSTK.EditMode = DataGridViewEditMode.EditProgrammatically;
                dgvDSTK.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DemSoTK();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemTaikhoan frmThemTaikhoan = new frmThemTaikhoan();
            //formThemtaikhoan.MdiParent = this;
            frmThemTaikhoan.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.SqlConnection.State == ConnectionState.Open) DataBase.SqlConnection.Close();
                DataBase.SqlConnection.Open();
                foreach (DataGridViewRow selectedRow in dgvDSTK.SelectedRows)
                {
                    string id = selectedRow.Cells["ID_USER"].Value.ToString();
                    string sqlDelete = "delete TAIKHOAN WHERE ID_USER = @id";
                    SqlCommand cmd = new SqlCommand(sqlDelete, DataBase.SqlConnection);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDGV_TaiKhoan();
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

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadDGV_TaiKhoan();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DemSoTK()
        {
            txtSoTK.ReadOnly = true;
            int count = dgvDSTK.RowCount;
            txtSoTK.Text = count.ToString();
        }
    }
}
