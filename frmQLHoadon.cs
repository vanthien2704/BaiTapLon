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
    public partial class frmQLHoadon : Form
    {
        public frmQLHoadon()
        {
            InitializeComponent();
        }

        private void frmQLHoadon_Load(object sender, EventArgs e)
        {
            LoadDL_MaHD();
            LoadDL_MaNH();
            LoadDL_MaHang();
            SetTextBox(false);
            SetButtons("Luu");
            SetTextBoxCT(false);
            SetButtonsCT("Luu");
        }
        private void LoadDGV_CTHoaDon()
        {
            try
            {
                string sql = @"select CTHOADON.MAHANG, TENHANG, SOLUONG, DONGIA, (SOLUONG*DONGIA) as THANHTIEN 
                                from HANGHOA INNER JOIN CTHOADON on HANGHOA.MAHANG = CTHOADON.MAHANG
                                where SOHD = '" + cbMahoadon.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, DataBase.SqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvHanghoa.DataSource = dt;
                dgvHanghoa.Columns[0].HeaderText = "Mã hàng";
                dgvHanghoa.Columns[1].HeaderText = "Tên hàng";
                dgvHanghoa.Columns[2].HeaderText = "Số lượng";
                dgvHanghoa.Columns[3].HeaderText = "Đơn giá";
                dgvHanghoa.Columns[4].HeaderText = "Thành tiền";
                dgvHanghoa.AllowUserToAddRows = false;
                dgvHanghoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvHanghoa.EditMode = DataGridViewEditMode.EditProgrammatically;
                dgvHanghoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                TongTienHD();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDL_MaHD()
        {
            try
            {
                string sql = "select SOHD from HOADON";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, DataBase.SqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbMahoadon.DataSource = dt;
                cbMahoadon.DisplayMember = "SOHD";
                cbMahoadon.ValueMember = "SOHD";
                LayDL_HoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDL_MaNH()
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
        private void LayDL_HoaDon()
        {
            try
            {
                if (DataBase.SqlConnection.State == ConnectionState.Open) DataBase.SqlConnection.Close();
                DataBase.SqlConnection.Open();
                string sql = @"select KHACHHANG, DIACHI, DIENTHOAI, NGAYHD, MANV
                            from HOADON where SOHD = @sohd";
                SqlCommand cmd = new SqlCommand(sql, DataBase.SqlConnection);
                cmd.Parameters.AddWithValue("@sohd", cbMahoadon.SelectedValue.ToString());
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    if (!rd.IsDBNull(0))
                    {
                        txtKhachhang.Text = rd.GetString(0);
                    }
                    else
                    {
                        txtKhachhang.Text = "";
                    }
                    if (!rd.IsDBNull(1))
                    {
                        txtDiachi.Text = rd.GetString(1);
                    }
                    else
                    {
                        txtDiachi.Text = "";
                    }
                    if (!rd.IsDBNull(2))
                    {
                        txtDienthoai.Text = rd.GetString(2);
                    }
                    else
                    {
                        txtDienthoai.Text = "";
                    }
                    if (!rd.IsDBNull(3))
                    {
                        dtpNgaylap.Value = rd.GetDateTime(3);
                    }
                    else
                    {
                        dtpNgaylap.Text = "";
                    }
                    if (!rd.IsDBNull(4))
                    {
                        cbManv.Text = rd.GetString(4);
                    }
                    else
                    {
                        cbManv.Text = "";
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

        private void cbMahoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayDL_HoaDon();
            LoadDGV_CTHoaDon();
        }
        private void SetTextBox(bool a)
        {
            txtKhachhang.Enabled =a;
            txtDiachi.Enabled = a;
            txtDienthoai.Enabled = a;
            dtpNgaylap.Enabled = a;
            cbManv.Enabled = a;
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
                    btnSua.Enabled = true;
                    btnLuu.Enabled = false;
                    btnXoa.Enabled = true;
                    break;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SetButtons("Them");
            SetTextBox(true);
            cbMahoadon.ResetText();
            txtKhachhang.Clear();
            txtDiachi.Clear();
            txtDienthoai.Clear();
            dtpNgaylap.ResetText();
            cbManv.ResetText();
        }

        bool capnhat = false;
        private void btnSua_Click(object sender, EventArgs e)
        {
            capnhat = true;
            cbMahoadon.Enabled = false;
            SetTextBox(true);
            SetButtons("Sua");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.SqlConnection.State == ConnectionState.Open)
                    DataBase.SqlConnection.Close();
                DataBase.SqlConnection.Open();

                string sql = "select count(*) from PHONGBAN where MAPHONG = '" + cbMahoadon.Text + "'";
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
                        string sqlupdate = @"update HOADON set 
                                            KHACHHANG = @khachhang, DIACHI = @diachi, DIENTHOAI = @sdt, NGAYHD = @ngaylap, MANV = @manv
                                            WHERE SOHD = '" + cbMahoadon.Text + "'";
                        SqlCommand cmd1 = new SqlCommand(sqlupdate, DataBase.SqlConnection);
                        cmd1.Parameters.AddWithValue("@khachhang", txtKhachhang.Text);
                        cmd1.Parameters.AddWithValue("@diachi", txtDiachi.Text);
                        cmd1.Parameters.AddWithValue("@sdt", txtDienthoai.Text);
                        cmd1.Parameters.AddWithValue("@ngaylap", dtpNgaylap.Text);
                        cmd1.Parameters.AddWithValue("@manv", cbManv.Text);
                        cmd1.ExecuteNonQuery();
                        cmd1.Dispose();
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDGV_CTHoaDon();
                        SetButtons("Luu");
                        SetTextBox(false);
                        capnhat = false;
                        cbMahoadon.Enabled = true;
                    }
                    else
                    {
                        string sqlinsert = @"insert into HOADON (SOHD, KHACHHANG, DIACHI, DIENTHOAI, NGAYHD, MANV)
                                            values (@sohd, @khachhang, @diachi, @sdt, @ngaylap, @manv)";
                        SqlCommand cmd1 = new SqlCommand(sqlinsert, DataBase.SqlConnection);
                        cmd1.Parameters.AddWithValue("@sohd", cbMahoadon.Text);
                        cmd1.Parameters.AddWithValue("@khachhang", txtKhachhang.Text);
                        cmd1.Parameters.AddWithValue("@diachi", txtDiachi.Text);
                        cmd1.Parameters.AddWithValue("@sdt", txtDienthoai.Text);
                        cmd1.Parameters.AddWithValue("@ngaylap", dtpNgaylap.Text);
                        cmd1.Parameters.AddWithValue("@manv", cbManv.Text);
                        cmd1.ExecuteNonQuery();
                        cmd1.Dispose();
                        MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDGV_CTHoaDon();
                        LoadDL_MaHD();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.SqlConnection.State == ConnectionState.Open)
                    DataBase.SqlConnection.Close();
                DataBase.SqlConnection.Open();
                string sqlDelete = "delete HOADON WHERE SOHD = @sohd";
                SqlCommand cmd = new SqlCommand(sqlDelete, DataBase.SqlConnection);
                cmd.Parameters.AddWithValue("@sohd", cbMahoadon.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDGV_CTHoaDon();
                LoadDL_MaHD();
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
        private void LoadDL_MaHang()
        {
            try
            {
                string sql = "select MAHANG from HANGHOA";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, DataBase.SqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbMahang.DataSource = dt;
                cbMahang.DisplayMember = "MAHANG";
                cbMahang.ValueMember = "MAHANG";
                LayDL_HangHoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LayDL_HangHoa()
        {
            try
            {
                if (DataBase.SqlConnection.State == ConnectionState.Open) DataBase.SqlConnection.Close();
                DataBase.SqlConnection.Open();
                string sql = @"select TENHANG from HANGHOA where MAHANG = @mahang";
                SqlCommand cmd = new SqlCommand(sql, DataBase.SqlConnection);
                cmd.Parameters.AddWithValue("@mahang", cbMahang.SelectedValue.ToString());
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    if (!rd.IsDBNull(0))
                    {
                        txtTenhang.Text = rd.GetString(0);
                    }
                    else
                    {
                        txtTenhang.Text = "";
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

        private void cbMahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayDL_HangHoa();
        }
        private void SetTextBoxCT(bool a)
        {
            cbMahang.Enabled = a;
            txtTenhang.Enabled = a;
            txtSoluong.Enabled = a;
        }
        private void SetButtonsCT(string mode)
        {
            switch (mode)
            {
                case "Them":
                    btnThemCT.Enabled = false;
                    btnSuaCT.Enabled = false;
                    btnLuuCT.Enabled = true;
                    btnXoaCT.Enabled = false;
                    break;

                case "Sua":
                    btnThemCT.Enabled = false;
                    btnSuaCT.Enabled = false;
                    btnLuuCT.Enabled = true;
                    btnXoaCT.Enabled = false;
                    break;

                case "Luu":
                    btnThemCT.Enabled = true;
                    btnSuaCT.Enabled = false;
                    btnLuuCT.Enabled = false;
                    btnXoaCT.Enabled = false;
                    break;
                case "CellClick":
                    btnSuaCT.Enabled = true;
                    btnXoaCT.Enabled = true;
                    break;
            }
        }
        private void dgvHanghoa_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                cbMahang.Text = dgvHanghoa.Rows[dong].Cells[0].Value.ToString();
                txtSoluong.Text = dgvHanghoa.Rows[dong].Cells[2].Value.ToString();
            }
            SetButtonsCT("CellClick");
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            SetTextBoxCT(true);
            SetButtonsCT("Them");
        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.SqlConnection.State == ConnectionState.Open)
                    DataBase.SqlConnection.Close();
                DataBase.SqlConnection.Open();

                string sql = "select count(*) from PHONGBAN where MAPHONG = '" + cbMahoadon.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, DataBase.SqlConnection);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Đã có mã phòng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (capnhatct == true)
                    {
                        int dong = dgvHanghoa.CurrentRow.Index;
                        string mahang = dgvHanghoa.Rows[dong].Cells[0].Value.ToString();
                        string sqlupdate = @"update CTHOADON set 
                                            SOHD = @sohd, MAHANG = @mahang, SOLUONG = @soluong
                                            WHERE SOHD = '" + cbMahoadon.Text + "' and MAHANG = '"+mahang+"'";
                        SqlCommand cmd1 = new SqlCommand(sqlupdate, DataBase.SqlConnection);
                        cmd1.Parameters.AddWithValue("@sohd", cbMahoadon.Text);
                        cmd1.Parameters.AddWithValue("@mahang", cbMahang.Text);
                        cmd1.Parameters.AddWithValue("@soluong", txtSoluong.Text);
                        cmd1.ExecuteNonQuery();
                        cmd1.Dispose();
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDGV_CTHoaDon();
                        SetButtonsCT("Luu");
                        SetTextBoxCT(false);
                        capnhatct = false;
                    }
                    else
                    {
                        string sqlinsert = @"insert into CTHOADON (SOHD, MAHANG, SOLUONG)
                                            values (@sohd, @mahang, @soluong)";
                        SqlCommand cmd1 = new SqlCommand(sqlinsert, DataBase.SqlConnection);
                        cmd1.Parameters.AddWithValue("@sohd", cbMahoadon.Text);
                        cmd1.Parameters.AddWithValue("@mahang", cbMahang.Text);
                        cmd1.Parameters.AddWithValue("@soluong", txtSoluong.Text);
                        cmd1.ExecuteNonQuery();
                        cmd1.Dispose();
                        MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDGV_CTHoaDon();
                        SetButtonsCT("Luu");
                        SetTextBoxCT(false);
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
        bool capnhatct = false;
        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            capnhatct = true;
            SetButtonsCT("Sua");
            SetTextBoxCT(true);
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.SqlConnection.State == ConnectionState.Open)
                    DataBase.SqlConnection.Close();
                DataBase.SqlConnection.Open();

                foreach (DataGridViewRow selectedRow in dgvHanghoa.SelectedRows)
                {
                    string mahang = selectedRow.Cells["MAHANG"].Value.ToString();
                    string sqlDelete = "delete CTHOADON WHERE MAHANG = @mahang and SOHD = '" + cbMahoadon.Text + "'";
                    SqlCommand cmd = new SqlCommand(sqlDelete, DataBase.SqlConnection);
                    cmd.Parameters.AddWithValue("@mahang", mahang);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDGV_CTHoaDon();
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
        private void TongTienHD()
        {
            txtGiatriHD.ReadOnly = true;
            decimal tongLuong = 0;
            foreach (DataGridViewRow row in dgvHanghoa.Rows)
            {
                decimal luong = Convert.ToDecimal(row.Cells[4].Value);
                tongLuong += luong;
            }
            txtGiatriHD.Text = tongLuong.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
