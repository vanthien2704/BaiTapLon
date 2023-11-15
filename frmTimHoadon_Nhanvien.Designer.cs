
namespace BaiTapLon
{
    partial class frmTimHoadon_Nhanvien
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
            this.cbManv = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtHesochucvu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHesoluong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHotennv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHoadon = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Controls.Add(this.cbManv);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn/Nhập mã nhân viên";
            // 
            // cbManv
            // 
            this.cbManv.FormattingEnabled = true;
            this.cbManv.Location = new System.Drawing.Point(34, 41);
            this.cbManv.Name = "cbManv";
            this.cbManv.Size = new System.Drawing.Size(195, 31);
            this.cbManv.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox2.Controls.Add(this.btnTimkiem);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 89);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(6, 29);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(120, 40);
            this.btnTimkiem.TabIndex = 20;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(132, 29);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 40);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LimeGreen;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dgvHoadon);
            this.groupBox3.Controls.Add(this.txtMaphong);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtpNgaysinh);
            this.groupBox3.Controls.Add(this.txtHesochucvu);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtPhai);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtHesoluong);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtHotennv);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(279, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(791, 529);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaysinh.Location = new System.Drawing.Point(175, 111);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(208, 30);
            this.dtpNgaysinh.TabIndex = 14;
            // 
            // txtHesochucvu
            // 
            this.txtHesochucvu.Location = new System.Drawing.Point(175, 164);
            this.txtHesochucvu.Name = "txtHesochucvu";
            this.txtHesochucvu.Size = new System.Drawing.Size(208, 30);
            this.txtHesochucvu.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Hệ số chức vụ";
            // 
            // txtPhai
            // 
            this.txtPhai.Location = new System.Drawing.Point(603, 64);
            this.txtPhai.Name = "txtPhai";
            this.txtPhai.Size = new System.Drawing.Size(128, 30);
            this.txtPhai.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Phái";
            // 
            // txtHesoluong
            // 
            this.txtHesoluong.Location = new System.Drawing.Point(603, 115);
            this.txtHesoluong.Name = "txtHesoluong";
            this.txtHesoluong.Size = new System.Drawing.Size(128, 30);
            this.txtHesoluong.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "HS lương";
            // 
            // txtHotennv
            // 
            this.txtHotennv.Location = new System.Drawing.Point(175, 64);
            this.txtHotennv.Name = "txtHotennv";
            this.txtHotennv.Size = new System.Drawing.Size(208, 30);
            this.txtHotennv.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Họ tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày sinh";
            // 
            // txtMaphong
            // 
            this.txtMaphong.Location = new System.Drawing.Point(603, 164);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(128, 30);
            this.txtMaphong.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã phòng";
            // 
            // dgvHoadon
            // 
            this.dgvHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoadon.Location = new System.Drawing.Point(6, 244);
            this.dgvHoadon.Name = "dgvHoadon";
            this.dgvHoadon.RowHeadersWidth = 51;
            this.dgvHoadon.RowTemplate.Height = 24;
            this.dgvHoadon.Size = new System.Drawing.Size(779, 278);
            this.dgvHoadon.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 35);
            this.label2.TabIndex = 18;
            this.label2.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(417, 35);
            this.label5.TabIndex = 19;
            this.label5.Text = "DANH SÁCH CÁC HÓA ĐƠN";
            // 
            // frmTimHoadon_Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTimHoadon_Nhanvien";
            this.Text = "Tìm Hóa Đơn Theo Nhân Viên";
            this.Load += new System.EventHandler(this.frmTimHoadon_Nhanvien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbManv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.TextBox txtHesochucvu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHesoluong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHotennv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHoadon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}