﻿namespace Quan_Li_Thu_Vien
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
            this.btnThem = new System.Windows.Forms.Button();
            this.panelNen = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTenTGNhap = new System.Windows.Forms.TextBox();
            this.lbTenTGTK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTG)).BeginInit();
            this.panelNen.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1244, 648);
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
            this.lbDanhSachNhanVienTrongTo.Location = new System.Drawing.Point(13, 10);
            this.lbDanhSachNhanVienTrongTo.Name = "lbDanhSachNhanVienTrongTo";
            this.lbDanhSachNhanVienTrongTo.Size = new System.Drawing.Size(315, 37);
            this.lbDanhSachNhanVienTrongTo.TabIndex = 1;
            this.lbDanhSachNhanVienTrongTo.Text = "Danh sách các tác giả";
            // 
            // dtgvTG
            // 
            this.dtgvTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTG.Location = new System.Drawing.Point(0, 101);
            this.dtgvTG.Name = "dtgvTG";
            this.dtgvTG.RowHeadersWidth = 51;
            this.dtgvTG.RowTemplate.Height = 24;
            this.dtgvTG.Size = new System.Drawing.Size(1355, 549);
            this.dtgvTG.TabIndex = 0;
            this.dtgvTG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTG_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = global::Quan_Li_Thu_Vien.Properties.Resources.add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(1138, 648);
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
            this.panelNen.Controls.Add(this.lbDanhSachNhanVienTrongTo);
            this.panelNen.Controls.Add(this.dtgvTG);
            this.panelNen.Location = new System.Drawing.Point(-3, -1);
            this.panelNen.Name = "panelNen";
            this.panelNen.Size = new System.Drawing.Size(1356, 650);
            this.panelNen.TabIndex = 12;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(1238, 49);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(109, 36);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTenTGNhap
            // 
            this.txtTenTGNhap.Location = new System.Drawing.Point(929, 49);
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
            this.lbTenTGTK.Location = new System.Drawing.Point(789, 54);
            this.lbTenTGTK.Name = "lbTenTGTK";
            this.lbTenTGTK.Size = new System.Drawing.Size(117, 25);
            this.lbTenTGTK.TabIndex = 3;
            this.lbTenTGTK.Text = "Tên Tác giả";
            // 
            // FDanhSachCacTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 690);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panelNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDanhSachCacTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDanhSachCacTacGia";
            this.Load += new System.EventHandler(this.FDanhSachCacTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTG)).EndInit();
            this.panelNen.ResumeLayout(false);
            this.panelNen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbDanhSachNhanVienTrongTo;
        private System.Windows.Forms.DataGridView dtgvTG;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panelNen;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTenTGNhap;
        private System.Windows.Forms.Label lbTenTGTK;
    }
}