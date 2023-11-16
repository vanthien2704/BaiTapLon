using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void DangNhap_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DSTaiKhoan_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSTaikhoan frmDSTaikhoan = new frmDSTaikhoan();
            frmDSTaikhoan.MdiParent = this;
            frmDSTaikhoan.Show();
        }

        private void ThemTK_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemTaikhoan frmThemTaikhoan = new frmThemTaikhoan();
            frmThemTaikhoan.MdiParent = this;
            frmThemTaikhoan.Show();
        }

        private void DangXuat_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMenu("");
        }
        public static bool thoat = false;
        private void Thoat_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thoat = true;
            this.Close();
        }

        private void QLPhongBan_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLPhongban frmQLPhongban = new frmQLPhongban();
            frmQLPhongban.MdiParent = this;
            frmQLPhongban.Show();
        }

        private void QLHangHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLHanghoa frmQLHanghoa = new frmQLHanghoa();
            frmQLHanghoa.MdiParent = this;
            frmQLHanghoa.Show();
        }

        private void QLNhanVien_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLNhanvien frmQLNhanvien = new frmQLNhanvien();
            frmQLNhanvien.MdiParent = this;
            frmQLNhanvien.Show();
        }

        private void QLHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLHoadon frmQLHoadon = new frmQLHoadon();
            frmQLHoadon.MdiParent = this;
            frmQLHoadon.Show();
        }

        private void DSNhanVien_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmDSNhanvien frmDSNhanvien = new frmDSNhanvien();
            //frmDSNhanvien.MdiParent = this;
            //frmDSNhanvien.Show();
        }

        private void TKNVTheoPhongBan_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTKNhanvien_Phong frmTKNhanvien_Phong = new frmTKNhanvien_Phong();
            frmTKNhanvien_Phong.MdiParent = this;
            frmTKNhanvien_Phong.Show();
        }

        private void TimHoaDonTheoNV_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimHoadon_Nhanvien frmTimHoadon_Nhanvien = new frmTimHoadon_Nhanvien();
            frmTimHoadon_Nhanvien.MdiParent = this;
            frmTimHoadon_Nhanvien.Show();
        }

        private void TimKiemHoaDon_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimkiemHoadon frmTimkiemHoadon = new frmTimkiemHoadon();
            frmTimkiemHoadon.MdiParent = this;
            frmTimkiemHoadon.Show();
        }

        private void XemHoaDon_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXemHoadon frmXemHoadon = new frmXemHoadon();
            frmXemHoadon.MdiParent = this;
            frmXemHoadon.Show();
        }
        private void LoadMenu(string quyen)
        {
            switch (quyen)
            {
                case "admin":
                    // Thực hiện hành động không được làm cho quyền Admin
                    break;
                case "nhanvien":
                    // Thực hiện hành động không được làm cho quyền Quản Lý
                    ThongTinTK_ToolStripMenuItem.Visible = false;
                    QLPhongBan_ToolStripMenuItem.Visible = false;
                    QLHangHoaToolStripMenuItem.Visible = false;
                    QLNhanVien_ToolStripMenuItem.Visible = false;
                    ThongKe_ToolStripMenuItem.Visible = false;
                    break;
                default:
                    //Thực hiện hành động không được làm cho quyền mặc định
                    ThongTinTK_ToolStripMenuItem.Visible = false;
                    DangXuat_ToolStripMenuItem.Visible = false;
                    NhapDuLieu_ToolStripMenuItem.Visible = false;
                    ThongKe_ToolStripMenuItem.Visible = false;
                    BaoCao_ToolStripMenuItem.Visible = false;
                    break;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadMenu(frmLogin.quyen);
        }
    }
}
