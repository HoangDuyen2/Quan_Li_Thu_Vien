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
            this.panelBangThongTinSach = new System.Windows.Forms.Panel();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtNamMat = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
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
            this.lbDanhSachNhanVienTrongTo.Location = new System.Drawing.Point(3, 12);
            this.lbDanhSachNhanVienTrongTo.Name = "lbDanhSachNhanVienTrongTo";
            this.lbDanhSachNhanVienTrongTo.Size = new System.Drawing.Size(315, 37);
            this.lbDanhSachNhanVienTrongTo.TabIndex = 1;
            this.lbDanhSachNhanVienTrongTo.Text = "Danh sách các tác giả";
            // 
            // dtgvTG
            // 
            this.dtgvTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTG.Location = new System.Drawing.Point(3, 63);
            this.dtgvTG.Name = "dtgvTG";
            this.dtgvTG.RowHeadersWidth = 51;
            this.dtgvTG.RowTemplate.Height = 24;
            this.dtgvTG.Size = new System.Drawing.Size(512, 533);
            this.dtgvTG.TabIndex = 0;
            this.dtgvTG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTG_CellContentClick);
            // 
            // txtTenTG
            // 
            this.txtTenTG.Enabled = false;
            this.txtTenTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTG.Location = new System.Drawing.Point(222, 160);
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
            this.panelNen.Controls.Add(this.panelBangThongTinSach);
            this.panelNen.Controls.Add(this.lbDanhSachNhanVienTrongTo);
            this.panelNen.Controls.Add(this.dtgvTG);
            this.panelNen.Location = new System.Drawing.Point(-1, -1);
            this.panelNen.Name = "panelNen";
            this.panelNen.Size = new System.Drawing.Size(1054, 599);
            this.panelNen.TabIndex = 12;
            // 
            // panelBangThongTinSach
            // 
            this.panelBangThongTinSach.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBangThongTinSach.Controls.Add(this.txtNamSinh);
            this.panelBangThongTinSach.Controls.Add(this.txtQueQuan);
            this.panelBangThongTinSach.Controls.Add(this.txtNamMat);
            this.panelBangThongTinSach.Controls.Add(this.txtGioiTinh);
            this.panelBangThongTinSach.Controls.Add(this.lbQueQuan);
            this.panelBangThongTinSach.Controls.Add(this.lbNamMat);
            this.panelBangThongTinSach.Controls.Add(this.lbNamSinh);
            this.panelBangThongTinSach.Controls.Add(this.lbGioiTinh);
            this.panelBangThongTinSach.Controls.Add(this.txtTenTG);
            this.panelBangThongTinSach.Controls.Add(this.txtMaTG);
            this.panelBangThongTinSach.Controls.Add(this.lbTenTG);
            this.panelBangThongTinSach.Controls.Add(this.lbMaTG);
            this.panelBangThongTinSach.Controls.Add(this.lbThongTinNhanVien);
            this.panelBangThongTinSach.Location = new System.Drawing.Point(518, 63);
            this.panelBangThongTinSach.Name = "panelBangThongTinSach";
            this.panelBangThongTinSach.Size = new System.Drawing.Size(536, 536);
            this.panelBangThongTinSach.TabIndex = 2;
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Enabled = false;
            this.txtNamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamSinh.Location = new System.Drawing.Point(222, 285);
            this.txtNamSinh.Multiline = true;
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(288, 30);
            this.txtNamSinh.TabIndex = 34;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Enabled = false;
            this.txtQueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueQuan.Location = new System.Drawing.Point(222, 405);
            this.txtQueQuan.Multiline = true;
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(288, 30);
            this.txtQueQuan.TabIndex = 33;
            // 
            // txtNamMat
            // 
            this.txtNamMat.Enabled = false;
            this.txtNamMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamMat.Location = new System.Drawing.Point(222, 345);
            this.txtNamMat.Multiline = true;
            this.txtNamMat.Name = "txtNamMat";
            this.txtNamMat.Size = new System.Drawing.Size(288, 30);
            this.txtNamMat.TabIndex = 32;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Enabled = false;
            this.txtGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiTinh.Location = new System.Drawing.Point(222, 225);
            this.txtGioiTinh.Multiline = true;
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(288, 30);
            this.txtGioiTinh.TabIndex = 31;
            // 
            // lbQueQuan
            // 
            this.lbQueQuan.AutoSize = true;
            this.lbQueQuan.BackColor = System.Drawing.Color.Transparent;
            this.lbQueQuan.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQueQuan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbQueQuan.Location = new System.Drawing.Point(34, 408);
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
            this.lbNamMat.Location = new System.Drawing.Point(34, 348);
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
            this.lbNamSinh.Location = new System.Drawing.Point(34, 288);
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
            this.lbGioiTinh.Location = new System.Drawing.Point(34, 228);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(90, 27);
            this.lbGioiTinh.TabIndex = 25;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // txtMaTG
            // 
            this.txtMaTG.Enabled = false;
            this.txtMaTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTG.Location = new System.Drawing.Point(222, 100);
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
            this.lbTenTG.Location = new System.Drawing.Point(34, 163);
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
            this.lbMaTG.Location = new System.Drawing.Point(34, 103);
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
            this.lbThongTinNhanVien.Location = new System.Drawing.Point(172, 5);
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
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label lbQueQuan;
        private System.Windows.Forms.Label lbNamMat;
        private System.Windows.Forms.Label lbNamSinh;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Button btnOK;
    }
}