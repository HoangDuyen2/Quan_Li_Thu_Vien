namespace Quan_Li_Thu_Vien
{
    partial class FDanhSachCacTacGia
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lbDanhSachNhanVienTrongTo = new System.Windows.Forms.Label();
            this.dtgvTG = new System.Windows.Forms.DataGridView();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.panelNen = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTenTGNhap = new System.Windows.Forms.TextBox();
            this.lbTenTGTK = new System.Windows.Forms.Label();
            this.panelBangThongTinSach = new System.Windows.Forms.Panel();
            this.radiobtnNu = new System.Windows.Forms.RadioButton();
            this.radiobtnNam = new System.Windows.Forms.RadioButton();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtNamMat = new System.Windows.Forms.TextBox();
            this.lbQueQuan = new System.Windows.Forms.Label();
            this.lbNamMat = new System.Windows.Forms.Label();
            this.lbNamSinh = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.txtMaTG = new System.Windows.Forms.TextBox();
            this.lbTenTG = new System.Windows.Forms.Label();
            this.lbMaTG = new System.Windows.Forms.Label();
            this.lbThongTinNhanVien = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTG)).BeginInit();
            this.panelNen.SuspendLayout();
            this.panelBangThongTinSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(944, 598);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 44);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbDanhSachNhanVienTrongTo
            // 
            this.lbDanhSachNhanVienTrongTo.AutoSize = true;
            this.lbDanhSachNhanVienTrongTo.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachNhanVienTrongTo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDanhSachNhanVienTrongTo.Location = new System.Drawing.Point(3, 0);
            this.lbDanhSachNhanVienTrongTo.Name = "lbDanhSachNhanVienTrongTo";
            this.lbDanhSachNhanVienTrongTo.Size = new System.Drawing.Size(315, 37);
            this.lbDanhSachNhanVienTrongTo.TabIndex = 1;
            this.lbDanhSachNhanVienTrongTo.Text = "Danh sách các tác giả";
            // 
            // dtgvTG
            // 
            this.dtgvTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTG.Location = new System.Drawing.Point(3, 104);
            this.dtgvTG.Name = "dtgvTG";
            this.dtgvTG.RowHeadersWidth = 51;
            this.dtgvTG.RowTemplate.Height = 24;
            this.dtgvTG.Size = new System.Drawing.Size(512, 492);
            this.dtgvTG.TabIndex = 0;
            this.dtgvTG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTG_CellContentClick);
            // 
            // txtTenTG
            // 
            this.txtTenTG.Enabled = false;
            this.txtTenTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTG.Location = new System.Drawing.Point(219, 150);
            this.txtTenTG.Multiline = true;
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(288, 30);
            this.txtTenTG.TabIndex = 13;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = global::Quan_Li_Thu_Vien.Properties.Resources.add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(727, 598);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 44);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Add";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panelNen
            // 
            this.panelNen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNen.Controls.Add(this.btnTimKiem);
            this.panelNen.Controls.Add(this.txtTenTGNhap);
            this.panelNen.Controls.Add(this.lbTenTGTK);
            this.panelNen.Controls.Add(this.panelBangThongTinSach);
            this.panelNen.Controls.Add(this.lbDanhSachNhanVienTrongTo);
            this.panelNen.Controls.Add(this.dtgvTG);
            this.panelNen.Location = new System.Drawing.Point(-1, -1);
            this.panelNen.Name = "panelNen";
            this.panelNen.Size = new System.Drawing.Size(1054, 599);
            this.panelNen.TabIndex = 12;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(447, 47);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(109, 36);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTenTGNhap
            // 
            this.txtTenTGNhap.Location = new System.Drawing.Point(153, 51);
            this.txtTenTGNhap.Multiline = true;
            this.txtTenTGNhap.Name = "txtTenTGNhap";
            this.txtTenTGNhap.Size = new System.Drawing.Size(288, 30);
            this.txtTenTGNhap.TabIndex = 4;
            // 
            // lbTenTGTK
            // 
            this.lbTenTGTK.AutoSize = true;
            this.lbTenTGTK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTenTGTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTGTK.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbTenTGTK.Location = new System.Drawing.Point(13, 56);
            this.lbTenTGTK.Name = "lbTenTGTK";
            this.lbTenTGTK.Size = new System.Drawing.Size(117, 25);
            this.lbTenTGTK.TabIndex = 3;
            this.lbTenTGTK.Text = "Tên Tác giả";
            // 
            // panelBangThongTinSach
            // 
            this.panelBangThongTinSach.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBangThongTinSach.Controls.Add(this.radiobtnNu);
            this.panelBangThongTinSach.Controls.Add(this.radiobtnNam);
            this.panelBangThongTinSach.Controls.Add(this.txtNamSinh);
            this.panelBangThongTinSach.Controls.Add(this.txtQueQuan);
            this.panelBangThongTinSach.Controls.Add(this.txtNamMat);
            this.panelBangThongTinSach.Controls.Add(this.lbQueQuan);
            this.panelBangThongTinSach.Controls.Add(this.lbNamMat);
            this.panelBangThongTinSach.Controls.Add(this.lbNamSinh);
            this.panelBangThongTinSach.Controls.Add(this.lbGioiTinh);
            this.panelBangThongTinSach.Controls.Add(this.txtTenTG);
            this.panelBangThongTinSach.Controls.Add(this.txtMaTG);
            this.panelBangThongTinSach.Controls.Add(this.lbTenTG);
            this.panelBangThongTinSach.Controls.Add(this.lbMaTG);
            this.panelBangThongTinSach.Controls.Add(this.lbThongTinNhanVien);
            this.panelBangThongTinSach.Location = new System.Drawing.Point(516, 104);
            this.panelBangThongTinSach.Name = "panelBangThongTinSach";
            this.panelBangThongTinSach.Size = new System.Drawing.Size(536, 495);
            this.panelBangThongTinSach.TabIndex = 2;
            // 
            // radiobtnNu
            // 
            this.radiobtnNu.AutoSize = true;
            this.radiobtnNu.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnNu.Location = new System.Drawing.Point(390, 216);
            this.radiobtnNu.Name = "radiobtnNu";
            this.radiobtnNu.Size = new System.Drawing.Size(60, 31);
            this.radiobtnNu.TabIndex = 36;
            this.radiobtnNu.Text = "Nữ";
            this.radiobtnNu.UseVisualStyleBackColor = true;
            // 
            // radiobtnNam
            // 
            this.radiobtnNam.AutoSize = true;
            this.radiobtnNam.Checked = true;
            this.radiobtnNam.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnNam.Location = new System.Drawing.Point(242, 216);
            this.radiobtnNam.Name = "radiobtnNam";
            this.radiobtnNam.Size = new System.Drawing.Size(79, 31);
            this.radiobtnNam.TabIndex = 35;
            this.radiobtnNam.TabStop = true;
            this.radiobtnNam.Text = "Nam";
            this.radiobtnNam.UseVisualStyleBackColor = true;
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Enabled = false;
            this.txtNamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamSinh.Location = new System.Drawing.Point(219, 275);
            this.txtNamSinh.Multiline = true;
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(288, 30);
            this.txtNamSinh.TabIndex = 34;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Enabled = false;
            this.txtQueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueQuan.Location = new System.Drawing.Point(219, 395);
            this.txtQueQuan.Multiline = true;
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(288, 30);
            this.txtQueQuan.TabIndex = 33;
            // 
            // txtNamMat
            // 
            this.txtNamMat.Enabled = false;
            this.txtNamMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamMat.Location = new System.Drawing.Point(219, 335);
            this.txtNamMat.Multiline = true;
            this.txtNamMat.Name = "txtNamMat";
            this.txtNamMat.Size = new System.Drawing.Size(288, 30);
            this.txtNamMat.TabIndex = 32;
            // 
            // lbQueQuan
            // 
            this.lbQueQuan.AutoSize = true;
            this.lbQueQuan.BackColor = System.Drawing.Color.Transparent;
            this.lbQueQuan.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQueQuan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbQueQuan.Location = new System.Drawing.Point(31, 398);
            this.lbQueQuan.Name = "lbQueQuan";
            this.lbQueQuan.Size = new System.Drawing.Size(105, 27);
            this.lbQueQuan.TabIndex = 28;
            this.lbQueQuan.Text = "Quê quán";
            // 
            // lbNamMat
            // 
            this.lbNamMat.AutoSize = true;
            this.lbNamMat.BackColor = System.Drawing.Color.Transparent;
            this.lbNamMat.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamMat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNamMat.Location = new System.Drawing.Point(31, 338);
            this.lbNamMat.Name = "lbNamMat";
            this.lbNamMat.Size = new System.Drawing.Size(101, 27);
            this.lbNamMat.TabIndex = 27;
            this.lbNamMat.Text = "Năm mất";
            // 
            // lbNamSinh
            // 
            this.lbNamSinh.AutoSize = true;
            this.lbNamSinh.BackColor = System.Drawing.Color.Transparent;
            this.lbNamSinh.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamSinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNamSinh.Location = new System.Drawing.Point(31, 278);
            this.lbNamSinh.Name = "lbNamSinh";
            this.lbNamSinh.Size = new System.Drawing.Size(102, 27);
            this.lbNamSinh.TabIndex = 26;
            this.lbNamSinh.Text = "Năm sinh";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.lbGioiTinh.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbGioiTinh.Location = new System.Drawing.Point(31, 218);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(90, 27);
            this.lbGioiTinh.TabIndex = 25;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // txtMaTG
            // 
            this.txtMaTG.Enabled = false;
            this.txtMaTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTG.Location = new System.Drawing.Point(219, 90);
            this.txtMaTG.Multiline = true;
            this.txtMaTG.Name = "txtMaTG";
            this.txtMaTG.Size = new System.Drawing.Size(288, 30);
            this.txtMaTG.TabIndex = 12;
            // 
            // lbTenTG
            // 
            this.lbTenTG.AutoSize = true;
            this.lbTenTG.BackColor = System.Drawing.Color.Transparent;
            this.lbTenTG.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTG.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTenTG.Location = new System.Drawing.Point(31, 153);
            this.lbTenTG.Name = "lbTenTG";
            this.lbTenTG.Size = new System.Drawing.Size(115, 27);
            this.lbTenTG.TabIndex = 5;
            this.lbTenTG.Text = "Tên tác giả";
            // 
            // lbMaTG
            // 
            this.lbMaTG.AutoSize = true;
            this.lbMaTG.BackColor = System.Drawing.Color.Transparent;
            this.lbMaTG.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaTG.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMaTG.Location = new System.Drawing.Point(31, 93);
            this.lbMaTG.Name = "lbMaTG";
            this.lbMaTG.Size = new System.Drawing.Size(112, 27);
            this.lbMaTG.TabIndex = 4;
            this.lbMaTG.Text = "Mã tác giả";
            // 
            // lbThongTinNhanVien
            // 
            this.lbThongTinNhanVien.AutoSize = true;
            this.lbThongTinNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lbThongTinNhanVien.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinNhanVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbThongTinNhanVien.Location = new System.Drawing.Point(184, 28);
            this.lbThongTinNhanVien.Name = "lbThongTinNhanVien";
            this.lbThongTinNhanVien.Size = new System.Drawing.Size(183, 27);
            this.lbThongTinNhanVien.TabIndex = 3;
            this.lbThongTinNhanVien.Text = "Thông tin tác giả";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Black;
            this.btnSua.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = global::Quan_Li_Thu_Vien.Properties.Resources.edit;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(835, 598);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(109, 44);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Edit";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOK.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(835, 598);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(109, 44);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FDanhSachCacTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 641);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panelNen);
            this.Controls.Add(this.btnSua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDanhSachCacTacGia";
            this.Text = "FDanhSachCacTacGia";
            this.Load += new System.EventHandler(this.FDanhSachCacTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTG)).EndInit();
            this.panelNen.ResumeLayout(false);
            this.panelNen.PerformLayout();
            this.panelBangThongTinSach.ResumeLayout(false);
            this.panelBangThongTinSach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbDanhSachNhanVienTrongTo;
        private System.Windows.Forms.DataGridView dtgvTG;
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panelNen;
        private System.Windows.Forms.Panel panelBangThongTinSach;
        private System.Windows.Forms.TextBox txtMaTG;
        private System.Windows.Forms.Label lbTenTG;
        private System.Windows.Forms.Label lbMaTG;
        private System.Windows.Forms.Label lbThongTinNhanVien;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtNamMat;
        private System.Windows.Forms.Label lbQueQuan;
        private System.Windows.Forms.Label lbNamMat;
        private System.Windows.Forms.Label lbNamSinh;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton radiobtnNu;
        private System.Windows.Forms.RadioButton radiobtnNam;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTenTGNhap;
        private System.Windows.Forms.Label lbTenTGTK;
    }
}