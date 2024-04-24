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
            this.panelNen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietPhieuPhat)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNen
            // 
            this.panelNen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNen.Controls.Add(this.lbLoaiPhat);
            this.panelNen.Controls.Add(this.comboBoxLoaiPhat);
            this.panelNen.Controls.Add(this.btnExit);
            this.panelNen.Controls.Add(this.lbDanhSachChiTietPhieuPhat);
            this.panelNen.Controls.Add(this.dtgvChiTietPhieuPhat);
            this.panelNen.Location = new System.Drawing.Point(-3, 1);
            this.panelNen.Name = "panelNen";
            this.panelNen.Size = new System.Drawing.Size(1042, 423);
            this.panelNen.TabIndex = 6;
            // 
            // lbLoaiPhat
            // 
            this.lbLoaiPhat.AutoSize = true;
            this.lbLoaiPhat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbLoaiPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiPhat.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbLoaiPhat.Location = new System.Drawing.Point(699, 82);
            this.lbLoaiPhat.Name = "lbLoaiPhat";
            this.lbLoaiPhat.Size = new System.Drawing.Size(94, 25);
            this.lbLoaiPhat.TabIndex = 12;
            this.lbLoaiPhat.Text = "Loại Phạt";
            // 
            // comboBoxLoaiPhat
            // 
            this.comboBoxLoaiPhat.FormattingEnabled = true;
            this.comboBoxLoaiPhat.Location = new System.Drawing.Point(810, 84);
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
            this.btnExit.Location = new System.Drawing.Point(933, 379);
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
            this.lbDanhSachChiTietPhieuPhat.Location = new System.Drawing.Point(23, 7);
            this.lbDanhSachChiTietPhieuPhat.Name = "lbDanhSachChiTietPhieuPhat";
            this.lbDanhSachChiTietPhieuPhat.Size = new System.Drawing.Size(440, 37);
            this.lbDanhSachChiTietPhieuPhat.TabIndex = 1;
            this.lbDanhSachChiTietPhieuPhat.Text = "Danh Sách Chi Tiết Phiếu Phạt";
            // 
            // dtgvChiTietPhieuPhat
            // 
            this.dtgvChiTietPhieuPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietPhieuPhat.Location = new System.Drawing.Point(3, 66);
            this.dtgvChiTietPhieuPhat.Name = "dtgvChiTietPhieuPhat";
            this.dtgvChiTietPhieuPhat.ReadOnly = true;
            this.dtgvChiTietPhieuPhat.RowHeadersWidth = 51;
            this.dtgvChiTietPhieuPhat.RowTemplate.Height = 24;
            this.dtgvChiTietPhieuPhat.Size = new System.Drawing.Size(681, 354);
            this.dtgvChiTietPhieuPhat.TabIndex = 0;
            // 
            // FChiTietPhieuPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 423);
            this.Controls.Add(this.panelNen);
            this.Name = "FChiTietPhieuPhat";
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
    }
}