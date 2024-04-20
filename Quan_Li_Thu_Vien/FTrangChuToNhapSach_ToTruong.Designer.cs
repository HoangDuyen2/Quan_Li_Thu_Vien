namespace Quan_Li_Thu_Vien
{
    partial class FTrangChuToNhapSach_ToTruong
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
            this.btn_DanhSachPhieuNhap = new System.Windows.Forms.Button();
            this.btn_ThongTinCaNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_DanhSachPhieuNhap
            // 
            this.btn_DanhSachPhieuNhap.Location = new System.Drawing.Point(21, 28);
            this.btn_DanhSachPhieuNhap.Name = "btn_DanhSachPhieuNhap";
            this.btn_DanhSachPhieuNhap.Size = new System.Drawing.Size(169, 53);
            this.btn_DanhSachPhieuNhap.TabIndex = 0;
            this.btn_DanhSachPhieuNhap.Text = "Danh Sách Phiếu Phạt";
            this.btn_DanhSachPhieuNhap.UseVisualStyleBackColor = true;
            this.btn_DanhSachPhieuNhap.Click += new System.EventHandler(this.btn_DanhSachPhieuNhap_Click);
            // 
            // btn_ThongTinCaNhan
            // 
            this.btn_ThongTinCaNhan.Location = new System.Drawing.Point(21, 363);
            this.btn_ThongTinCaNhan.Name = "btn_ThongTinCaNhan";
            this.btn_ThongTinCaNhan.Size = new System.Drawing.Size(169, 57);
            this.btn_ThongTinCaNhan.TabIndex = 1;
            this.btn_ThongTinCaNhan.Text = "Thông Tin Cá Nhân";
            this.btn_ThongTinCaNhan.UseVisualStyleBackColor = true;
            this.btn_ThongTinCaNhan.Click += new System.EventHandler(this.btn_ThongTinCaNhan_Click);
            // 
            // FTrangChuToNhapSach_ToTruong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.btn_ThongTinCaNhan);
            this.Controls.Add(this.btn_DanhSachPhieuNhap);
            this.Name = "FTrangChuToNhapSach_ToTruong";
            this.Text = "FTrangChuToNhapSach_ToTruong";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DanhSachPhieuNhap;
        private System.Windows.Forms.Button btn_ThongTinCaNhan;
    }
}