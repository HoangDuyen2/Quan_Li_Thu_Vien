namespace Quan_Li_Thu_Vien
{
    partial class FTrangChuToNhapSach_NhanVien
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
            this.btn_nhap_sach = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_thong_tin_ca_nhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_nhap_sach
            // 
            this.btn_nhap_sach.Location = new System.Drawing.Point(25, 22);
            this.btn_nhap_sach.Name = "btn_nhap_sach";
            this.btn_nhap_sach.Size = new System.Drawing.Size(217, 63);
            this.btn_nhap_sach.TabIndex = 0;
            this.btn_nhap_sach.Text = "Nhập Sách";
            this.btn_nhap_sach.UseVisualStyleBackColor = true;
            this.btn_nhap_sach.Click += new System.EventHandler(this.btn_nhap_sach_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "Xem Phiếu Nhập Sách";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_thong_tin_ca_nhan
            // 
            this.btn_thong_tin_ca_nhan.Location = new System.Drawing.Point(25, 486);
            this.btn_thong_tin_ca_nhan.Name = "btn_thong_tin_ca_nhan";
            this.btn_thong_tin_ca_nhan.Size = new System.Drawing.Size(217, 52);
            this.btn_thong_tin_ca_nhan.TabIndex = 2;
            this.btn_thong_tin_ca_nhan.Text = "Thông Tin Cá Nhân";
            this.btn_thong_tin_ca_nhan.UseVisualStyleBackColor = true;
            this.btn_thong_tin_ca_nhan.Click += new System.EventHandler(this.btn_thong_tin_ca_nhan_Click);
            // 
            // TrangChuToNhapSach_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 550);
            this.Controls.Add(this.btn_thong_tin_ca_nhan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_nhap_sach);
            this.Name = "TrangChuToNhapSach_NhanVien";
            this.Text = "TrangChuToNhapSach_NhanVien";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_nhap_sach;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_thong_tin_ca_nhan;
    }
}