using System;

namespace Quan_Li_Thu_Vien
{
    partial class FTrangChuToSach_ToTruong
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
            this.picBoxNen = new System.Windows.Forms.PictureBox();
            this.panelMucLuc = new System.Windows.Forms.Panel();
            this.btnDSNXB = new System.Windows.Forms.Button();
            this.btnThongTinCaNhan = new System.Windows.Forms.Button();
            this.btnDSTacGia = new System.Windows.Forms.Button();
            this.btnDanhSachSachDangMuon = new System.Windows.Forms.Button();
            this.btnDanhSachCacSachBiHu = new System.Windows.Forms.Button();
            this.btnXemDSSach = new System.Windows.Forms.Button();
            this.btnDSNhanVien = new System.Windows.Forms.Button();
            this.panelNen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNen)).BeginInit();
            this.panelMucLuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNen
            // 
            this.panelNen.Controls.Add(this.picBoxNen);
            this.panelNen.Controls.Add(this.panelMucLuc);
            this.panelNen.Location = new System.Drawing.Point(0, 0);
            this.panelNen.Name = "panelNen";
            this.panelNen.Size = new System.Drawing.Size(1052, 600);
            this.panelNen.TabIndex = 0;
            // 
            // picBoxNen
            // 
            this.picBoxNen.BackgroundImage = global::Quan_Li_Thu_Vien.Properties.Resources.biaAnh;
            this.picBoxNen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxNen.Location = new System.Drawing.Point(212, 1);
            this.picBoxNen.Name = "picBoxNen";
            this.picBoxNen.Size = new System.Drawing.Size(840, 599);
            this.picBoxNen.TabIndex = 1;
            this.picBoxNen.TabStop = false;
            // 
            // panelMucLuc
            // 
            this.panelMucLuc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMucLuc.Controls.Add(this.btnDSNXB);
            this.panelMucLuc.Controls.Add(this.btnThongTinCaNhan);
            this.panelMucLuc.Controls.Add(this.btnDSTacGia);
            this.panelMucLuc.Controls.Add(this.btnDanhSachSachDangMuon);
            this.panelMucLuc.Controls.Add(this.btnDanhSachCacSachBiHu);
            this.panelMucLuc.Controls.Add(this.btnXemDSSach);
            this.panelMucLuc.Controls.Add(this.btnDSNhanVien);
            this.panelMucLuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelMucLuc.Location = new System.Drawing.Point(-1, 2);
            this.panelMucLuc.Name = "panelMucLuc";
            this.panelMucLuc.Size = new System.Drawing.Size(213, 595);
            this.panelMucLuc.TabIndex = 0;
            // 
            // btnDSNXB
            // 
            this.btnDSNXB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDSNXB.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSNXB.Location = new System.Drawing.Point(-4, 265);
            this.btnDSNXB.Name = "btnDSNXB";
            this.btnDSNXB.Size = new System.Drawing.Size(214, 65);
            this.btnDSNXB.TabIndex = 13;
            this.btnDSNXB.Text = "Danh sách nhà xuất bản";
            this.btnDSNXB.UseVisualStyleBackColor = false;
            this.btnDSNXB.Click += new System.EventHandler(this.btnDSNXB_Click);
            // 
            // btnThongTinCaNhan
            // 
            this.btnThongTinCaNhan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThongTinCaNhan.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTinCaNhan.Location = new System.Drawing.Point(-1, 404);
            this.btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            this.btnThongTinCaNhan.Size = new System.Drawing.Size(214, 65);
            this.btnThongTinCaNhan.TabIndex = 12;
            this.btnThongTinCaNhan.Text = "Thông tin cá nhân";
            this.btnThongTinCaNhan.UseVisualStyleBackColor = false;
            this.btnThongTinCaNhan.Click += new System.EventHandler(this.btnThongTinCaNhan_Click);
            // 
            // btnDSTacGia
            // 
            this.btnDSTacGia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDSTacGia.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSTacGia.Location = new System.Drawing.Point(-4, 198);
            this.btnDSTacGia.Name = "btnDSTacGia";
            this.btnDSTacGia.Size = new System.Drawing.Size(214, 65);
            this.btnDSTacGia.TabIndex = 11;
            this.btnDSTacGia.Text = "Danh sách tác giả";
            this.btnDSTacGia.UseVisualStyleBackColor = false;
            this.btnDSTacGia.Click += new System.EventHandler(this.btnDSTacGia_Click);
            // 
            // btnDanhSachSachDangMuon
            // 
            this.btnDanhSachSachDangMuon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDanhSachSachDangMuon.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachSachDangMuon.Location = new System.Drawing.Point(-4, 66);
            this.btnDanhSachSachDangMuon.Name = "btnDanhSachSachDangMuon";
            this.btnDanhSachSachDangMuon.Size = new System.Drawing.Size(214, 65);
            this.btnDanhSachSachDangMuon.TabIndex = 10;
            this.btnDanhSachSachDangMuon.Text = "     Danh sách sách      đang mượn";
            this.btnDanhSachSachDangMuon.UseVisualStyleBackColor = false;
            this.btnDanhSachSachDangMuon.Click += new System.EventHandler(this.btnDanhSachSachDangMuon_Click);
            // 
            // btnDanhSachCacSachBiHu
            // 
            this.btnDanhSachCacSachBiHu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDanhSachCacSachBiHu.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachCacSachBiHu.Location = new System.Drawing.Point(-4, 132);
            this.btnDanhSachCacSachBiHu.Name = "btnDanhSachCacSachBiHu";
            this.btnDanhSachCacSachBiHu.Size = new System.Drawing.Size(214, 65);
            this.btnDanhSachCacSachBiHu.TabIndex = 9;
            this.btnDanhSachCacSachBiHu.Text = "     Danh sách sách      bị hư";
            this.btnDanhSachCacSachBiHu.UseVisualStyleBackColor = false;
            this.btnDanhSachCacSachBiHu.Click += new System.EventHandler(this.btnDanhSachCacSachBiHu_Click);
            // 
            // btnXemDSSach
            // 
            this.btnXemDSSach.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXemDSSach.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDSSach.Location = new System.Drawing.Point(-4, 0);
            this.btnXemDSSach.Name = "btnXemDSSach";
            this.btnXemDSSach.Size = new System.Drawing.Size(214, 65);
            this.btnXemDSSach.TabIndex = 8;
            this.btnXemDSSach.Text = "Danh sách các sách";
            this.btnXemDSSach.UseVisualStyleBackColor = false;
            this.btnXemDSSach.Click += new System.EventHandler(this.btnXemDSSach_Click);
            // 
            // btnDSNhanVien
            // 
            this.btnDSNhanVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDSNhanVien.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSNhanVien.Location = new System.Drawing.Point(-2, 333);
            this.btnDSNhanVien.Name = "btnDSNhanVien";
            this.btnDSNhanVien.Size = new System.Drawing.Size(214, 65);
            this.btnDSNhanVien.TabIndex = 4;
            this.btnDSNhanVien.Text = "Danh sách nhân viên";
            this.btnDSNhanVien.UseVisualStyleBackColor = false;
            this.btnDSNhanVien.Click += new System.EventHandler(this.btnDSNhanVien_Click);
            // 
            // FTrangChuToSach_ToTruong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 597);
            this.Controls.Add(this.panelNen);
            this.Name = "FTrangChuToSach_ToTruong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTrangChuToSach_ToTruong";
            this.panelNen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNen)).EndInit();
            this.panelMucLuc.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel panelNen;
        private System.Windows.Forms.Panel panelMucLuc;
        private System.Windows.Forms.Button btnDSNhanVien;
        private System.Windows.Forms.PictureBox picBoxNen;
        private System.Windows.Forms.Button btnDSNXB;
        private System.Windows.Forms.Button btnThongTinCaNhan;
        private System.Windows.Forms.Button btnDSTacGia;
        private System.Windows.Forms.Button btnDanhSachSachDangMuon;
        private System.Windows.Forms.Button btnDanhSachCacSachBiHu;
        private System.Windows.Forms.Button btnXemDSSach;
    }
}