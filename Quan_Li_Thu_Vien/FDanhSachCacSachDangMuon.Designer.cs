namespace Quan_Li_Thu_Vien
{
    partial class FDanhSachCacSachDangMuon
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
            this.lbDanhSachCacCuonSach = new System.Windows.Forms.Label();
            this.dtgvSach = new System.Windows.Forms.DataGridView();
            this.panelNen = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lbNgayKetThuc = new System.Windows.Forms.Label();
            this.lbNgayMuon = new System.Windows.Forms.Label();
            this.dtBatDau = new System.Windows.Forms.DateTimePicker();
            this.lbTinhTrang = new System.Windows.Forms.Label();
            this.comboBoxTinhTrang = new System.Windows.Forms.ComboBox();
            this.dtKetThuc = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).BeginInit();
            this.panelNen.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1245, 648);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 44);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbDanhSachCacCuonSach
            // 
            this.lbDanhSachCacCuonSach.AutoSize = true;
            this.lbDanhSachCacCuonSach.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachCacCuonSach.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDanhSachCacCuonSach.Location = new System.Drawing.Point(-4, 0);
            this.lbDanhSachCacCuonSach.Name = "lbDanhSachCacCuonSach";
            this.lbDanhSachCacCuonSach.Size = new System.Drawing.Size(526, 37);
            this.lbDanhSachCacCuonSach.TabIndex = 1;
            this.lbDanhSachCacCuonSach.Text = "Danh sách các cuốn sách đang mượn";
            // 
            // dtgvSach
            // 
            this.dtgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSach.Location = new System.Drawing.Point(0, 100);
            this.dtgvSach.Name = "dtgvSach";
            this.dtgvSach.ReadOnly = true;
            this.dtgvSach.RowHeadersWidth = 51;
            this.dtgvSach.RowTemplate.Height = 24;
            this.dtgvSach.Size = new System.Drawing.Size(1355, 549);
            this.dtgvSach.TabIndex = 0;
            this.dtgvSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSach_CellContentClick);
            // 
            // panelNen
            // 
            this.panelNen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNen.Controls.Add(this.dtKetThuc);
            this.panelNen.Controls.Add(this.lbTinhTrang);
            this.panelNen.Controls.Add(this.comboBoxTinhTrang);
            this.panelNen.Controls.Add(this.dtBatDau);
            this.panelNen.Controls.Add(this.lbNgayMuon);
            this.panelNen.Controls.Add(this.btnTimKiem);
            this.panelNen.Controls.Add(this.lbNgayKetThuc);
            this.panelNen.Controls.Add(this.lbDanhSachCacCuonSach);
            this.panelNen.Controls.Add(this.dtgvSach);
            this.panelNen.Location = new System.Drawing.Point(-1, -1);
            this.panelNen.Name = "panelNen";
            this.panelNen.Size = new System.Drawing.Size(1355, 649);
            this.panelNen.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(1221, 53);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(109, 36);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lbNgayKetThuc
            // 
            this.lbNgayKetThuc.AutoSize = true;
            this.lbNgayKetThuc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayKetThuc.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbNgayKetThuc.Location = new System.Drawing.Point(816, 57);
            this.lbNgayKetThuc.Name = "lbNgayKetThuc";
            this.lbNgayKetThuc.Size = new System.Drawing.Size(131, 25);
            this.lbNgayKetThuc.TabIndex = 9;
            this.lbNgayKetThuc.Text = "Ngày kết thúc";
            // 
            // lbNgayMuon
            // 
            this.lbNgayMuon.AutoSize = true;
            this.lbNgayMuon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayMuon.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbNgayMuon.Location = new System.Drawing.Point(393, 59);
            this.lbNgayMuon.Name = "lbNgayMuon";
            this.lbNgayMuon.Size = new System.Drawing.Size(128, 25);
            this.lbNgayMuon.TabIndex = 13;
            this.lbNgayMuon.Text = "Ngày bắt đầu";
            // 
            // dtBatDau
            // 
            this.dtBatDau.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBatDau.Location = new System.Drawing.Point(532, 57);
            this.dtBatDau.Name = "dtBatDau";
            this.dtBatDau.Size = new System.Drawing.Size(244, 27);
            this.dtBatDau.TabIndex = 14;
            // 
            // lbTinhTrang
            // 
            this.lbTinhTrang.AutoSize = true;
            this.lbTinhTrang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinhTrang.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbTinhTrang.Location = new System.Drawing.Point(31, 59);
            this.lbTinhTrang.Name = "lbTinhTrang";
            this.lbTinhTrang.Size = new System.Drawing.Size(100, 25);
            this.lbTinhTrang.TabIndex = 16;
            this.lbTinhTrang.Text = "Tình trạng";
            // 
            // comboBoxTinhTrang
            // 
            this.comboBoxTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTinhTrang.FormattingEnabled = true;
            this.comboBoxTinhTrang.Items.AddRange(new object[] {
            "Đã trả",
            "Chưa trả"});
            this.comboBoxTinhTrang.Location = new System.Drawing.Point(137, 58);
            this.comboBoxTinhTrang.Name = "comboBoxTinhTrang";
            this.comboBoxTinhTrang.Size = new System.Drawing.Size(215, 28);
            this.comboBoxTinhTrang.TabIndex = 15;
            this.comboBoxTinhTrang.Text = "Chưa trả";
            this.comboBoxTinhTrang.SelectedIndexChanged += new System.EventHandler(this.comboBoxTinhTrang_SelectedIndexChanged);
            // 
            // dtKetThuc
            // 
            this.dtKetThuc.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtKetThuc.Location = new System.Drawing.Point(961, 58);
            this.dtKetThuc.Name = "dtKetThuc";
            this.dtKetThuc.Size = new System.Drawing.Size(244, 27);
            this.dtKetThuc.TabIndex = 17;
            // 
            // FDanhSacCacSachDangMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 690);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDanhSacCacSachDangMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDanhSacCacSachDangMuon";
            this.Load += new System.EventHandler(this.FDanhSacCacSachDangMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).EndInit();
            this.panelNen.ResumeLayout(false);
            this.panelNen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbDanhSachCacCuonSach;
        private System.Windows.Forms.DataGridView dtgvSach;
        private System.Windows.Forms.Panel panelNen;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lbNgayKetThuc;
        private System.Windows.Forms.Label lbNgayMuon;
        private System.Windows.Forms.DateTimePicker dtBatDau;
        private System.Windows.Forms.Label lbTinhTrang;
        private System.Windows.Forms.ComboBox comboBoxTinhTrang;
        private System.Windows.Forms.DateTimePicker dtKetThuc;
    }
}