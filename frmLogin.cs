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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public static string quyen = "";
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMatkhau.Text) ||
                string.IsNullOrWhiteSpace(txtTenTK.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string matkhaulogin = txtMatkhau.Text;
                if (DataBase.SqlConnection.State == ConnectionState.Open) DataBase.SqlConnection.Close();
                DataBase.SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT TENTK, MATKHAU, QUYEN FROM TAIKHOAN WHERE TENTK = @tentk", DataBase.SqlConnection);
                cmd.Parameters.AddWithValue("@tentk", txtTenTK.Text);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    string matkhauDB = rd["MATKHAU"].ToString();
                    bool kiemtramk = BCrypt.Net.BCrypt.Verify(matkhaulogin, matkhauDB);
                    quyen = rd.GetString(2);
                    if (kiemtramk)
                    {
                        rd.Close();
                        this.Hide();
                        frmMain frmMain = new frmMain();
                        frmMain.ShowDialog();
                        if(frmMain.thoat == true)
                        {
                            Application.Exit();
                        }    
                        txtTenTK.Clear();
                        txtMatkhau.Clear();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            Application.Exit();
        }
    }
}
