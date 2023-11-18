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
    public partial class frmDSNhanvien : Form
    {
        public frmDSNhanvien()
        {
            InitializeComponent();
        }

        private void frmDSNhanvien_Load(object sender, EventArgs e)
        {
            LoadDL_NhanVien();
        }
        private void LoadDL_NhanVien()
        {
            try
            {
                string sql = @"select MANV, HOTEN, (CASE WHEN PHAI = 1 THEN N'Nam' ELSE N'Nữ' END) as PHAI,
                                 NGAYSINH, HSLUONG, HSCHUCVU, CAST((HSLUONG+HSCHUCVU)*1300000 AS INT) AS LUONG, TENPHONG 
                                    from NHANVIEN INNER JOIN PHONGBAN ON NHANVIEN.MAPHONG = PHONGBAN.MAPHONG";
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
                dgvNhanvien.Columns[7].HeaderText = "Phòng ban";
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
    }
}
