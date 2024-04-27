namespace Quan_Li_Thu_Vien
{
    partial class FormDangNhap
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radbtnToTruong = new System.Windows.Forms.RadioButton();
            this.radbtnNhanVien = new System.Windows.Forms.RadioButton();
            this.radbtnNguoiQuanLy = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnThoat);
            this.panel6.Location = new System.Drawing.Point(384, 137);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(138, 66);
            this.panel6.TabIndex = 28;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(7, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 59);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDangNhap);
            this.panel5.Location = new System.Drawing.Point(212, 137);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(138, 66);
            this.panel5.TabIndex = 27;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(3, 3);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(128, 59);
            this.btnDangNhap.TabIndex = 0;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radbtnToTruong);
            this.panel1.Controls.Add(this.radbtnNhanVien);
            this.panel1.Controls.Add(this.radbtnNguoiQuanLy);
            this.panel1.Location = new System.Drawing.Point(12, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 83);
            this.panel1.TabIndex = 26;
            // 
            // radbtnToTruong
            // 
            this.radbtnToTruong.AutoSize = true;
            this.radbtnToTruong.Location = new System.Drawing.Point(11, 55);
            this.radbtnToTruong.Name = "radbtnToTruong";
            this.radbtnToTruong.Size = new System.Drawing.Size(91, 20);
            this.radbtnToTruong.TabIndex = 20;
            this.radbtnToTruong.TabStop = true;
            this.radbtnToTruong.Text = "Tổ Trưởng";
            this.radbtnToTruong.UseVisualStyleBackColor = true;
            // 
            // radbtnNhanVien
            // 
            this.radbtnNhanVien.AutoSize = true;
            this.radbtnNhanVien.Location = new System.Drawing.Point(11, 29);
            this.radbtnNhanVien.Name = "radbtnNhanVien";
            this.radbtnNhanVien.Size = new System.Drawing.Size(90, 20);
            this.radbtnNhanVien.TabIndex = 19;
            this.radbtnNhanVien.TabStop = true;
            this.radbtnNhanVien.Text = "Nhân Viên";
            this.radbtnNhanVien.UseVisualStyleBackColor = true;
            // 
            // radbtnNguoiQuanLy
            // 
            this.radbtnNguoiQuanLy.AutoSize = true;
            this.radbtnNguoiQuanLy.Location = new System.Drawing.Point(11, 3);
            this.radbtnNguoiQuanLy.Name = "radbtnNguoiQuanLy";
            this.radbtnNguoiQuanLy.Size = new System.Drawing.Size(116, 20);
            this.radbtnNguoiQuanLy.TabIndex = 18;
            this.radbtnNguoiQuanLy.TabStop = true;
            this.radbtnNguoiQuanLy.Text = "Người Quản Lý";
            this.radbtnNguoiQuanLy.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMatKhau);
            this.panel3.Controls.Add(this.lblMatKhau);
            this.panel3.Location = new System.Drawing.Point(12, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(510, 48);
            this.panel3.TabIndex = 25;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(200, 12);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(307, 22);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(7, 12);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(107, 24);
            this.lblMatKhau.TabIndex = 0;
            this.lblMatKhau.Text = "Mật Khẩu:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTenDangNhap);
            this.panel2.Controls.Add(this.lblTenDangNhap);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 48);
            this.panel2.TabIndex = 24;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(200, 12);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(307, 22);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.Location = new System.Drawing.Point(3, 12);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(163, 24);
            this.lblTenDangNhap.TabIndex = 0;
            this.lblTenDangNhap.Text = "Tên Đăng Nhập:";
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 213);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDangNhap_FormClosing);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radbtnToTruong;
        private System.Windows.Forms.RadioButton radbtnNhanVien;
        private System.Windows.Forms.RadioButton radbtnNguoiQuanLy;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblTenDangNhap;
    }
}