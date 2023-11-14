
namespace BaiTapLon
{
    partial class frmQLNhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtHesochucvu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTienluong = new System.Windows.Forms.TextBox();
            this.txtHesoluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHotennv = new System.Windows.Forms.TextBox();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuumoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuusua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LimeGreen;
            this.groupBox1.Controls.Add(this.dtpNgaysinh);
            this.groupBox1.Controls.Add(this.txtHesochucvu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPhai);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTienluong);
            this.groupBox1.Controls.Add(this.txtHesoluong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtHotennv);
            this.groupBox1.Controls.Add(this.txtManv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 259);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaysinh.Location = new System.Drawing.Point(149, 74);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(171, 30);
            this.dtpNgaysinh.TabIndex = 14;
            // 
            // txtHesochucvu
            // 
            this.txtHesochucvu.Location = new System.Drawing.Point(496, 127);
            this.txtHesochucvu.Name = "txtHesochucvu";
            this.txtHesochucvu.Size = new System.Drawing.Size(259, 30);
            this.txtHesochucvu.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Hệ số chức vụ";
            // 
            // txtPhai
            // 
            this.txtPhai.Location = new System.Drawing.Point(496, 77);
            this.txtPhai.Name = "txtPhai";
            this.txtPhai.Size = new System.Drawing.Size(259, 30);
            this.txtPhai.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Phái";
            // 
            // txtTienluong
            // 
            this.txtTienluong.Location = new System.Drawing.Point(149, 177);
            this.txtTienluong.Name = "txtTienluong";
            this.txtTienluong.Size = new System.Drawing.Size(171, 30);
            this.txtTienluong.TabIndex = 9;
            // 
            // txtHesoluong
            // 
            this.txtHesoluong.Location = new System.Drawing.Point(149, 129);
            this.txtHesoluong.Name = "txtHesoluong";
            this.txtHesoluong.Size = new System.Drawing.Size(171, 30);
            this.txtHesoluong.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tiền lương";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hệ số lương";
            // 
            // txtHotennv
            // 
            this.txtHotennv.Location = new System.Drawing.Point(496, 27);
            this.txtHotennv.Name = "txtHotennv";
            this.txtHotennv.Size = new System.Drawing.Size(259, 30);
            this.txtHotennv.TabIndex = 5;
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(149, 27);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(171, 30);
            this.txtManv.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Họ tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Pink;
            this.groupBox2.Controls.Add(this.btnLuumoi);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnLuusua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(797, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 259);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ĐIỀU KHIỂN";
            // 
            // btnLuumoi
            // 
            this.btnLuumoi.Location = new System.Drawing.Point(6, 100);
            this.btnLuumoi.Name = "btnLuumoi";
            this.btnLuumoi.Size = new System.Drawing.Size(120, 50);
            this.btnLuumoi.TabIndex = 5;
            this.btnLuumoi.Text = "Lưu mới";
            this.btnLuumoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuumoi.UseVisualStyleBackColor = true;
            this.btnLuumoi.Click += new System.EventHandler(this.btnLuumoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(147, 175);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 50);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuusua
            // 
            this.btnLuusua.Location = new System.Drawing.Point(147, 100);
            this.btnLuusua.Name = "btnLuusua";
            this.btnLuusua.Size = new System.Drawing.Size(120, 50);
            this.btnLuusua.TabIndex = 3;
            this.btnLuusua.Text = "Lưu sửa";
            this.btnLuusua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuusua.UseVisualStyleBackColor = true;
            this.btnLuusua.Click += new System.EventHandler(this.btnLuusua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(6, 175);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 50);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(147, 24);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 50);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(6, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 50);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.Location = new System.Drawing.Point(12, 329);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.RowHeadersWidth = 51;
            this.dgvNhanvien.RowTemplate.Height = 24;
            this.dgvNhanvien.Size = new System.Drawing.Size(1058, 212);
            this.dgvNhanvien.TabIndex = 5;
            this.dgvNhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanvien_CellClick);
            // 
            // frmQLNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.dgvNhanvien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLNhanvien";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.frmQLNhanvien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHotennv;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLuumoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuusua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTienluong;
        private System.Windows.Forms.TextBox txtHesoluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHesochucvu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.DataGridView dgvNhanvien;
    }
}