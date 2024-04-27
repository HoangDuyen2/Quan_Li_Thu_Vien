namespace Quan_Li_Thu_Vien
{
    partial class FChiTietPhieuPhat
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
            this.lbLoaiPhat = new System.Windows.Forms.Label();
            this.comboBoxLoaiPhat = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbDanhSachChiTietPhieuPhat = new System.Windows.Forms.Label();
            this.dtgvChiTietPhieuPhat = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemMaSach = new System.Windows.Forms.Button();
            this.panelNen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietPhieuPhat)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNen
            // 
            this.panelNen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNen.Controls.Add(this.btnThemMaSach);
            this.panelNen.Controls.Add(this.btnXoa);
            this.panelNen.Controls.Add(this.lbLoaiPhat);
            this.panelNen.Controls.Add(this.comboBoxLoaiPhat);
            this.panelNen.Controls.Add(this.btnExit);
            this.panelNen.Controls.Add(this.lbDanhSachChiTietPhieuPhat);
            this.panelNen.Controls.Add(this.dtgvChiTietPhieuPhat);
            this.panelNen.Location = new System.Drawing.Point(-1, -1);
            this.panelNen.Name = "panelNen";
            this.panelNen.Size = new System.Drawing.Size(1046, 640);
            this.panelNen.TabIndex = 6;
            // 
            // lbLoaiPhat
            // 
            this.lbLoaiPhat.AutoSize = true;
            this.lbLoaiPhat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbLoaiPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiPhat.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbLoaiPhat.Location = new System.Drawing.Point(700, 179);
            this.lbLoaiPhat.Name = "lbLoaiPhat";
            this.lbLoaiPhat.Size = new System.Drawing.Size(94, 25);
            this.lbLoaiPhat.TabIndex = 12;
            this.lbLoaiPhat.Text = "Loại Phạt";
            // 
            // comboBoxLoaiPhat
            // 
            this.comboBoxLoaiPhat.FormattingEnabled = true;
            this.comboBoxLoaiPhat.Location = new System.Drawing.Point(810, 179);
            this.comboBoxLoaiPhat.Name = "comboBoxLoaiPhat";
            this.comboBoxLoaiPhat.Size = new System.Drawing.Size(215, 24);
            this.comboBoxLoaiPhat.TabIndex = 11;
            this.comboBoxLoaiPhat.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoaiPhat_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(937, 594);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 44);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbDanhSachChiTietPhieuPhat
            // 
            this.lbDanhSachChiTietPhieuPhat.AutoSize = true;
            this.lbDanhSachChiTietPhieuPhat.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachChiTietPhieuPhat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDanhSachChiTietPhieuPhat.Location = new System.Drawing.Point(27, 24);
            this.lbDanhSachChiTietPhieuPhat.Name = "lbDanhSachChiTietPhieuPhat";
            this.lbDanhSachChiTietPhieuPhat.Size = new System.Drawing.Size(440, 37);
            this.lbDanhSachChiTietPhieuPhat.TabIndex = 1;
            this.lbDanhSachChiTietPhieuPhat.Text = "Danh Sách Chi Tiết Phiếu Phạt";
            // 
            // dtgvChiTietPhieuPhat
            // 
            this.dtgvChiTietPhieuPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietPhieuPhat.Location = new System.Drawing.Point(13, 89);
            this.dtgvChiTietPhieuPhat.Name = "dtgvChiTietPhieuPhat";
            this.dtgvChiTietPhieuPhat.ReadOnly = true;
            this.dtgvChiTietPhieuPhat.RowHeadersWidth = 51;
            this.dtgvChiTietPhieuPhat.RowTemplate.Height = 24;
            this.dtgvChiTietPhieuPhat.Size = new System.Drawing.Size(681, 508);
            this.dtgvChiTietPhieuPhat.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(855, 289);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 44);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemMaSach
            // 
            this.btnThemMaSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThemMaSach.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMaSach.ForeColor = System.Drawing.Color.White;
            this.btnThemMaSach.Location = new System.Drawing.Point(855, 227);
            this.btnThemMaSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemMaSach.Name = "btnThemMaSach";
            this.btnThemMaSach.Size = new System.Drawing.Size(109, 44);
            this.btnThemMaSach.TabIndex = 14;
            this.btnThemMaSach.Text = "Thêm";
            this.btnThemMaSach.UseVisualStyleBackColor = false;
            this.btnThemMaSach.Click += new System.EventHandler(this.btnThemChiTIetPhieuPhat_Click);
            // 
            // FChiTietPhieuPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 637);
            this.Controls.Add(this.panelNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FChiTietPhieuPhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FChiTietPhieuPhat";
            this.Load += new System.EventHandler(this.FChiTietPhieuPhat_Load);
            this.panelNen.ResumeLayout(false);
            this.panelNen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietPhieuPhat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNen;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbDanhSachChiTietPhieuPhat;
        private System.Windows.Forms.DataGridView dtgvChiTietPhieuPhat;
        private System.Windows.Forms.Label lbLoaiPhat;
        private System.Windows.Forms.ComboBox comboBoxLoaiPhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemMaSach;
    }
}