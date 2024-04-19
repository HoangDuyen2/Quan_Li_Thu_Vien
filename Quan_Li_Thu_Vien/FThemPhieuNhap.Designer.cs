namespace Quan_Li_Thu_Vien
{
    partial class FThemPhieuNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_tao_phieu = new System.Windows.Forms.Button();
            this.ngayNhap = new System.Windows.Forms.TextBox();
            this.maNcc = new System.Windows.Forms.TextBox();
            this.giaTri = new System.Windows.Forms.TextBox();
            this.donGia = new System.Windows.Forms.TextBox();
            this.soLuong = new System.Windows.Forms.TextBox();
            this.maNv = new System.Windows.Forms.TextBox();
            this.tenSach = new System.Windows.Forms.TextBox();
            this.view_list_phieu_nhap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.view_list_phieu_nhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo Phiếu Nhập Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá Trị Đơn Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã nhà cung cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(839, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(839, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(831, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã người tạo phiếu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tên Sách";
            // 
            // btn_tao_phieu
            // 
            this.btn_tao_phieu.Location = new System.Drawing.Point(834, 489);
            this.btn_tao_phieu.Name = "btn_tao_phieu";
            this.btn_tao_phieu.Size = new System.Drawing.Size(163, 46);
            this.btn_tao_phieu.TabIndex = 8;
            this.btn_tao_phieu.Text = "Tạo phiếu nhập sách";
            this.btn_tao_phieu.UseVisualStyleBackColor = true;
            this.btn_tao_phieu.Click += new System.EventHandler(this.btn_tao_phieu_Click);
            // 
            // ngayNhap
            // 
            this.ngayNhap.Location = new System.Drawing.Point(576, 136);
            this.ngayNhap.Name = "ngayNhap";
            this.ngayNhap.Size = new System.Drawing.Size(194, 22);
            this.ngayNhap.TabIndex = 10;
            // 
            // maNcc
            // 
            this.maNcc.Location = new System.Drawing.Point(576, 322);
            this.maNcc.Name = "maNcc";
            this.maNcc.Size = new System.Drawing.Size(194, 22);
            this.maNcc.TabIndex = 11;
            this.maNcc.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // giaTri
            // 
            this.giaTri.Location = new System.Drawing.Point(576, 219);
            this.giaTri.Name = "giaTri";
            this.giaTri.Size = new System.Drawing.Size(194, 22);
            this.giaTri.TabIndex = 12;
            // 
            // donGia
            // 
            this.donGia.Location = new System.Drawing.Point(970, 133);
            this.donGia.Name = "donGia";
            this.donGia.Size = new System.Drawing.Size(193, 22);
            this.donGia.TabIndex = 13;
            // 
            // soLuong
            // 
            this.soLuong.Location = new System.Drawing.Point(970, 219);
            this.soLuong.Name = "soLuong";
            this.soLuong.Size = new System.Drawing.Size(193, 22);
            this.soLuong.TabIndex = 14;
            // 
            // maNv
            // 
            this.maNv.Location = new System.Drawing.Point(970, 322);
            this.maNv.Name = "maNv";
            this.maNv.Size = new System.Drawing.Size(193, 22);
            this.maNv.TabIndex = 15;
            // 
            // tenSach
            // 
            this.tenSach.Location = new System.Drawing.Point(576, 409);
            this.tenSach.Name = "tenSach";
            this.tenSach.Size = new System.Drawing.Size(194, 22);
            this.tenSach.TabIndex = 16;
            this.tenSach.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // view_list_phieu_nhap
            // 
            this.view_list_phieu_nhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_list_phieu_nhap.Location = new System.Drawing.Point(12, 73);
            this.view_list_phieu_nhap.Name = "view_list_phieu_nhap";
            this.view_list_phieu_nhap.RowHeadersWidth = 51;
            this.view_list_phieu_nhap.RowTemplate.Height = 24;
            this.view_list_phieu_nhap.Size = new System.Drawing.Size(422, 475);
            this.view_list_phieu_nhap.TabIndex = 17;
            this.view_list_phieu_nhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_list_phieu_nhap_CellContentClick);
            // 
            // FThemPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 591);
            this.Controls.Add(this.view_list_phieu_nhap);
            this.Controls.Add(this.tenSach);
            this.Controls.Add(this.maNv);
            this.Controls.Add(this.soLuong);
            this.Controls.Add(this.donGia);
            this.Controls.Add(this.giaTri);
            this.Controls.Add(this.maNcc);
            this.Controls.Add(this.ngayNhap);
            this.Controls.Add(this.btn_tao_phieu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FThemPhieuNhap";
            this.Text = "FThemPhieuNhap";
            ((System.ComponentModel.ISupportInitialize)(this.view_list_phieu_nhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_tao_phieu;
        private System.Windows.Forms.TextBox ngayNhap;
        private System.Windows.Forms.TextBox maNcc;
        private System.Windows.Forms.TextBox giaTri;
        private System.Windows.Forms.TextBox donGia;
        private System.Windows.Forms.TextBox soLuong;
        private System.Windows.Forms.TextBox maNv;
        private System.Windows.Forms.TextBox tenSach;
        private System.Windows.Forms.DataGridView view_list_phieu_nhap;
    }
}