namespace Quan_Li_Thu_Vien
{
    partial class FNewNCC
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
            this.panelBangThongTinSach = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.lbTenNCC = new System.Windows.Forms.Label();
            this.lbMaNCC = new System.Windows.Forms.Label();
            this.lbThongTinNCC = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.panelBangThongTinSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBangThongTinSach
            // 
            this.panelBangThongTinSach.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelBangThongTinSach.Controls.Add(this.txtSDT);
            this.panelBangThongTinSach.Controls.Add(this.txtDiaChi);
            this.panelBangThongTinSach.Controls.Add(this.lbSDT);
            this.panelBangThongTinSach.Controls.Add(this.lbDiaChi);
            this.panelBangThongTinSach.Controls.Add(this.btnExit);
            this.panelBangThongTinSach.Controls.Add(this.btnOK);
            this.panelBangThongTinSach.Controls.Add(this.txtTenNCC);
            this.panelBangThongTinSach.Controls.Add(this.txtMaNCC);
            this.panelBangThongTinSach.Controls.Add(this.lbTenNCC);
            this.panelBangThongTinSach.Controls.Add(this.lbMaNCC);
            this.panelBangThongTinSach.Controls.Add(this.lbThongTinNCC);
            this.panelBangThongTinSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBangThongTinSach.Location = new System.Drawing.Point(-2, 1);
            this.panelBangThongTinSach.Name = "panelBangThongTinSach";
            this.panelBangThongTinSach.Size = new System.Drawing.Size(1036, 638);
            this.panelBangThongTinSach.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(547, 574);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 42);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOK.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(413, 574);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(136, 42);
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNCC.Location = new System.Drawing.Point(498, 262);
            this.txtTenNCC.Multiline = true;
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(288, 30);
            this.txtTenNCC.TabIndex = 16;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Enabled = false;
            this.txtMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.Location = new System.Drawing.Point(498, 160);
            this.txtMaNCC.Multiline = true;
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(288, 30);
            this.txtMaNCC.TabIndex = 12;
            // 
            // lbTenNCC
            // 
            this.lbTenNCC.AutoSize = true;
            this.lbTenNCC.BackColor = System.Drawing.Color.Transparent;
            this.lbTenNCC.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.lbTenNCC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTenNCC.Location = new System.Drawing.Point(283, 262);
            this.lbTenNCC.Name = "lbTenNCC";
            this.lbTenNCC.Size = new System.Drawing.Size(195, 28);
            this.lbTenNCC.TabIndex = 8;
            this.lbTenNCC.Text = "Tên nhà cung cấp";
            // 
            // lbMaNCC
            // 
            this.lbMaNCC.AutoSize = true;
            this.lbMaNCC.BackColor = System.Drawing.Color.Transparent;
            this.lbMaNCC.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNCC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMaNCC.Location = new System.Drawing.Point(283, 162);
            this.lbMaNCC.Name = "lbMaNCC";
            this.lbMaNCC.Size = new System.Drawing.Size(187, 28);
            this.lbMaNCC.TabIndex = 4;
            this.lbMaNCC.Text = "Mã nhà cung cấp";
            // 
            // lbThongTinNCC
            // 
            this.lbThongTinNCC.AutoSize = true;
            this.lbThongTinNCC.BackColor = System.Drawing.Color.Transparent;
            this.lbThongTinNCC.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinNCC.ForeColor = System.Drawing.Color.Blue;
            this.lbThongTinNCC.Location = new System.Drawing.Point(345, 36);
            this.lbThongTinNCC.Name = "lbThongTinNCC";
            this.lbThongTinNCC.Size = new System.Drawing.Size(414, 44);
            this.lbThongTinNCC.TabIndex = 3;
            this.lbThongTinNCC.Text = "Thông tin nhà cung cấp";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(498, 452);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(288, 30);
            this.txtSDT.TabIndex = 31;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(498, 357);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(288, 30);
            this.txtDiaChi.TabIndex = 30;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.BackColor = System.Drawing.Color.Transparent;
            this.lbSDT.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.lbSDT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSDT.Location = new System.Drawing.Point(283, 452);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(144, 28);
            this.lbSDT.TabIndex = 29;
            this.lbSDT.Text = "Số điện thoại";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.lbDiaChi.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDiaChi.Location = new System.Drawing.Point(283, 359);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(81, 28);
            this.lbDiaChi.TabIndex = 28;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // FNewNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 638);
            this.Controls.Add(this.panelBangThongTinSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FNewNCC";
            this.Text = "FNewNCC";
            this.Load += new System.EventHandler(this.FNewNCC_Load);
            this.panelBangThongTinSach.ResumeLayout(false);
            this.panelBangThongTinSach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBangThongTinSach;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label lbTenNCC;
        private System.Windows.Forms.Label lbMaNCC;
        private System.Windows.Forms.Label lbThongTinNCC;
    }
}