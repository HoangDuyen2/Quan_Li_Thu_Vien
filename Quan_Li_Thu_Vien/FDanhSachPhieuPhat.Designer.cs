namespace Quan_Li_Thu_Vien
{
    partial class FDanhSachPhieuPhat
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
            this.panelNen = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbLoaiViPham = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.lbMaSach = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbDanhSachPhieuPhat = new System.Windows.Forms.Label();
            this.dtgvPhieuPhat = new System.Windows.Forms.DataGridView();
            this.panelNen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuPhat)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNen
            // 
            this.panelNen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNen.Controls.Add(this.comboBox1);
            this.panelNen.Controls.Add(this.lbLoaiViPham);
            this.panelNen.Controls.Add(this.btnTimKiem);
            this.panelNen.Controls.Add(this.txtMaSach);
            this.panelNen.Controls.Add(this.lbMaSach);
            this.panelNen.Controls.Add(this.btnExit);
            this.panelNen.Controls.Add(this.btnThem);
            this.panelNen.Controls.Add(this.lbDanhSachPhieuPhat);
            this.panelNen.Controls.Add(this.dtgvPhieuPhat);
            this.panelNen.Location = new System.Drawing.Point(-1, 2);
            this.panelNen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNen.Name = "panelNen";
            this.panelNen.Size = new System.Drawing.Size(1357, 693);
            this.panelNen.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tất cả",
            "Trễ hạn"});
            this.comboBox1.Location = new System.Drawing.Point(572, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 24);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbLoaiViPham
            // 
            this.lbLoaiViPham.AutoSize = true;
            this.lbLoaiViPham.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbLoaiViPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiViPham.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbLoaiViPham.Location = new System.Drawing.Point(435, 56);
            this.lbLoaiViPham.Name = "lbLoaiViPham";
            this.lbLoaiViPham.Size = new System.Drawing.Size(122, 25);
            this.lbLoaiViPham.TabIndex = 17;
            this.lbLoaiViPham.Text = "Loại vi phạm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(1203, 52);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(109, 36);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(925, 57);
            this.txtMaSach.Multiline = true;
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(258, 30);
            this.txtMaSach.TabIndex = 13;
            // 
            // lbMaSach
            // 
            this.lbMaSach.AutoSize = true;
            this.lbMaSach.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSach.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbMaSach.Location = new System.Drawing.Point(809, 57);
            this.lbMaSach.Name = "lbMaSach";
            this.lbMaSach.Size = new System.Drawing.Size(91, 25);
            this.lbMaSach.TabIndex = 12;
            this.lbMaSach.Text = "Mã Sách";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1248, 649);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 44);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(1108, 649);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(144, 44);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbDanhSachPhieuPhat
            // 
            this.lbDanhSachPhieuPhat.AutoSize = true;
            this.lbDanhSachPhieuPhat.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachPhieuPhat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDanhSachPhieuPhat.Location = new System.Drawing.Point(5, 0);
            this.lbDanhSachPhieuPhat.Name = "lbDanhSachPhieuPhat";
            this.lbDanhSachPhieuPhat.Size = new System.Drawing.Size(324, 37);
            this.lbDanhSachPhieuPhat.TabIndex = 1;
            this.lbDanhSachPhieuPhat.Text = "Danh Sách Phiếu Phạt";
            // 
            // dtgvPhieuPhat
            // 
            this.dtgvPhieuPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhieuPhat.Location = new System.Drawing.Point(2, 102);
            this.dtgvPhieuPhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvPhieuPhat.Name = "dtgvPhieuPhat";
            this.dtgvPhieuPhat.ReadOnly = true;
            this.dtgvPhieuPhat.RowHeadersWidth = 51;
            this.dtgvPhieuPhat.RowTemplate.Height = 24;
            this.dtgvPhieuPhat.Size = new System.Drawing.Size(1355, 550);
            this.dtgvPhieuPhat.TabIndex = 0;
            this.dtgvPhieuPhat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPhieuPhat_CellContentClick);
            // 
            // FDanhSachPhieuPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 694);
            this.Controls.Add(this.panelNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FDanhSachPhieuPhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDanhSachPhieuPhat";
            this.Load += new System.EventHandler(this.FDanhSachPhieuPhat_Load);
            this.panelNen.ResumeLayout(false);
            this.panelNen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuPhat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNen;
        private System.Windows.Forms.Label lbDanhSachPhieuPhat;
        private System.Windows.Forms.DataGridView dtgvPhieuPhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label lbMaSach;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbLoaiViPham;
    }
}