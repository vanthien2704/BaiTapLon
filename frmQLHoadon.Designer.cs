
namespace BaiTapLon
{
    partial class frmQLHoadon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbManv = new System.Windows.Forms.ComboBox();
            this.cbMahoadon = new System.Windows.Forms.ComboBox();
            this.dtpNgaylap = new System.Windows.Forms.DateTimePicker();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKhachhang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnLuuCT = new System.Windows.Forms.Button();
            this.btnSuaCT = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.cbMahang = new System.Windows.Forms.ComboBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvHanghoa = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtGiatriHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanghoa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LimeGreen;
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cbManv);
            this.groupBox1.Controls.Add(this.cbMahoadon);
            this.groupBox1.Controls.Add(this.dtpNgaylap);
            this.groupBox1.Controls.Add(this.txtDienthoai);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtKhachhang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 266);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN ĐƠN HÀNG";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(380, 177);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 40);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(380, 127);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 40);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(380, 77);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 40);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(380, 27);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbManv
            // 
            this.cbManv.FormattingEnabled = true;
            this.cbManv.Location = new System.Drawing.Point(149, 227);
            this.cbManv.Name = "cbManv";
            this.cbManv.Size = new System.Drawing.Size(196, 31);
            this.cbManv.TabIndex = 16;
            // 
            // cbMahoadon
            // 
            this.cbMahoadon.FormattingEnabled = true;
            this.cbMahoadon.Location = new System.Drawing.Point(149, 27);
            this.cbMahoadon.Name = "cbMahoadon";
            this.cbMahoadon.Size = new System.Drawing.Size(196, 31);
            this.cbMahoadon.TabIndex = 15;
            this.cbMahoadon.SelectedIndexChanged += new System.EventHandler(this.cbMahoadon_SelectedIndexChanged);
            // 
            // dtpNgaylap
            // 
            this.dtpNgaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaylap.Location = new System.Drawing.Point(149, 184);
            this.dtpNgaylap.Name = "dtpNgaylap";
            this.dtpNgaylap.Size = new System.Drawing.Size(196, 30);
            this.dtpNgaylap.TabIndex = 14;
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Location = new System.Drawing.Point(149, 147);
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(196, 30);
            this.txtDienthoai.TabIndex = 13;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(149, 107);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(196, 30);
            this.txtDiachi.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Địa chỉ";
            // 
            // txtKhachhang
            // 
            this.txtKhachhang.Location = new System.Drawing.Point(149, 67);
            this.txtKhachhang.Name = "txtKhachhang";
            this.txtKhachhang.Size = new System.Drawing.Size(196, 30);
            this.txtKhachhang.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LimeGreen;
            this.groupBox2.Controls.Add(this.btnXoaCT);
            this.groupBox2.Controls.Add(this.btnLuuCT);
            this.groupBox2.Controls.Add(this.btnSuaCT);
            this.groupBox2.Controls.Add(this.btnThemCT);
            this.groupBox2.Controls.Add(this.cbMahang);
            this.groupBox2.Controls.Add(this.txtSoluong);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTenhang);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(551, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 266);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CHI TIẾT ĐƠN HÀNG";
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Location = new System.Drawing.Point(380, 177);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(120, 40);
            this.btnXoaCT.TabIndex = 20;
            this.btnXoaCT.Text = "Xóa";
            this.btnXoaCT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaCT.UseVisualStyleBackColor = true;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // btnLuuCT
            // 
            this.btnLuuCT.Location = new System.Drawing.Point(380, 127);
            this.btnLuuCT.Name = "btnLuuCT";
            this.btnLuuCT.Size = new System.Drawing.Size(120, 40);
            this.btnLuuCT.TabIndex = 19;
            this.btnLuuCT.Text = "Lưu";
            this.btnLuuCT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuCT.UseVisualStyleBackColor = true;
            this.btnLuuCT.Click += new System.EventHandler(this.btnLuuCT_Click);
            // 
            // btnSuaCT
            // 
            this.btnSuaCT.Location = new System.Drawing.Point(380, 77);
            this.btnSuaCT.Name = "btnSuaCT";
            this.btnSuaCT.Size = new System.Drawing.Size(120, 40);
            this.btnSuaCT.TabIndex = 18;
            this.btnSuaCT.Text = "Sửa";
            this.btnSuaCT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaCT.UseVisualStyleBackColor = true;
            this.btnSuaCT.Click += new System.EventHandler(this.btnSuaCT_Click);
            // 
            // btnThemCT
            // 
            this.btnThemCT.Location = new System.Drawing.Point(380, 27);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(120, 40);
            this.btnThemCT.TabIndex = 17;
            this.btnThemCT.Text = "Thêm";
            this.btnThemCT.UseVisualStyleBackColor = true;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // cbMahang
            // 
            this.cbMahang.FormattingEnabled = true;
            this.cbMahang.Location = new System.Drawing.Point(149, 27);
            this.cbMahang.Name = "cbMahang";
            this.cbMahang.Size = new System.Drawing.Size(196, 31);
            this.cbMahang.TabIndex = 15;
            this.cbMahang.SelectedIndexChanged += new System.EventHandler(this.cbMahang_SelectedIndexChanged);
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(149, 107);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(196, 30);
            this.txtSoluong.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "Số lượng";
            // 
            // txtTenhang
            // 
            this.txtTenhang.Location = new System.Drawing.Point(149, 67);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(196, 30);
            this.txtTenhang.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tên hàng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mã hàng";
            // 
            // dgvHanghoa
            // 
            this.dgvHanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHanghoa.Location = new System.Drawing.Point(12, 284);
            this.dgvHanghoa.Name = "dgvHanghoa";
            this.dgvHanghoa.RowHeadersWidth = 51;
            this.dgvHanghoa.RowTemplate.Height = 24;
            this.dgvHanghoa.Size = new System.Drawing.Size(935, 223);
            this.dgvHanghoa.TabIndex = 5;
            this.dgvHanghoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHanghoa_CellClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(953, 357);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 61);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtGiatriHD
            // 
            this.txtGiatriHD.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiatriHD.Location = new System.Drawing.Point(486, 513);
            this.txtGiatriHD.Name = "txtGiatriHD";
            this.txtGiatriHD.Size = new System.Drawing.Size(295, 34);
            this.txtGiatriHD.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tổng giá trị hóa đơn";
            // 
            // frmQLHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.txtGiatriHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvHanghoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLHoadon";
            this.Text = "Quản Lý Hóa Đơn";
            this.Load += new System.EventHandler(this.frmQLHoadon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanghoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgaylap;
        private System.Windows.Forms.TextBox txtDienthoai;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKhachhang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbManv;
        private System.Windows.Forms.ComboBox cbMahoadon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnLuuCT;
        private System.Windows.Forms.Button btnSuaCT;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.ComboBox cbMahang;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvHanghoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtGiatriHD;
        private System.Windows.Forms.Label label1;
    }
}