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
    public partial class frmThemTaikhoan : Form
    {
        public frmThemTaikhoan()
        {
            InitializeComponent();
        }
        private bool KiemTraTenTK(string username)
        {
            // Kiểm tra xem chuỗi có chứa khoảng trắng hay không
            if (username.Contains(" "))
            {
                return false;
            }
            // Kiểm tra xem chuỗi có chứa ký tự viết hoa hay không
            if (username.Any(char.IsUpper))
            {
                return false;
            }

            return true;
        }
        private bool KiemTraPass(string password)
        {
            // Kiểm tra xem chuỗi có chứa khoảng trắng hay không
            if (password.Contains(" "))
            {
                return false;
            }
            return true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtID.Text) ||
                    string.IsNullOrWhiteSpace(txtMatkhau.Text) ||
                    string.IsNullOrWhiteSpace(txtTenTK.Text) ||
                    string.IsNullOrWhiteSpace(txtQuyen.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string[] validRoles = { "admin", "nhanvien" };
                if (!validRoles.Contains(txtQuyen.Text))
                {
                    MessageBox.Show("Quyền không hợp lệ. Vui lòng chỉ chọn 'admin' hoặc 'nhanvien'.");
                    return;
                }

                if (KiemTraTenTK(txtTenTK.Text) && KiemTraPass(txtMatkhau.Text))
                {
                    if (DataBase.SqlConnection.State == ConnectionState.Open) DataBase.SqlConnection.Close();
                    DataBase.SqlConnection.Open();
                    string sql = "select count(*) from taikhoan where id_user = '" + txtID.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, DataBase.SqlConnection);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Đã có tài khoản này rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string password = BCrypt.Net.BCrypt.HashPassword(txtMatkhau.Text);
                        string sqlinsert = @"insert into taikhoan (ID_USER, TENTK, MATKHAU, QUYEN)
                        values (@id, @tentk, @matkhau, @quyen)";
                        SqlCommand cmd1 = new SqlCommand(sqlinsert, DataBase.SqlConnection);
                        cmd1.Parameters.AddWithValue("@id", txtID.Text);
                        cmd1.Parameters.AddWithValue("@tentk", txtTenTK.Text);
                        cmd1.Parameters.AddWithValue("@matkhau", password);
                        cmd1.Parameters.AddWithValue("@quyen", txtQuyen.Text);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Đã lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmd1.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin không hợp lệ. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
