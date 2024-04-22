namespace Quan_Li_Thu_Vien
{
    partial class FDanhSachDocGia
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTenDocGia = new System.Windows.Forms.TextBox();
            this.lbTenSach = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbDanhSachDocGia = new System.Windows.Forms.Label();
            this.dtgvDocGia = new System.Windows.Forms.DataGridView();
            this.panelNen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNen
            // 
            this.panelNen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNen.Controls.Add(this.btnTimKiem);
            this.panelNen.Controls.Add(this.txtTenDocGia);
            this.panelNen.Controls.Add(this.lbTenSach);
            this.panelNen.Controls.Add(this.btnExit);
            this.panelNen.Controls.Add(this.btnXoa);
            this.panelNen.Controls.Add(this.btnSua);
            this.panelNen.Controls.Add(this.btnThem);
            this.panelNen.Controls.Add(this.lbDanhSachDocGia);
            this.panelNen.Controls.Add(this.dtgvDocGia);
            this.panelNen.Location = new System.Drawing.Point(1, 3);
            this.panelNen.Name = "panelNen";
            this.panelNen.Size = new System.Drawing.Size(1354, 650);
            this.panelNen.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(1220, 53);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(109, 36);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Location = new System.Drawing.Point(942, 58);
            this.txtTenDocGia.Multiline = true;
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.Size = new System.Drawing.Size(258, 30);
            this.txtTenDocGia.TabIndex = 13;
            // 
            // lbTenSach
            // 
            this.lbTenSach.AutoSize = true;
            this.lbTenSach.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSach.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbTenSach.Location = new System.Drawing.Point(801, 59);
            this.lbTenSach.Name = "lbTenSach";
            this.lbTenSach.Size = new System.Drawing.Size(122, 25);
            this.lbTenSach.TabIndex = 12;
            this.lbTenSach.Text = "Tên Độc Giả";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1242, 606);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 44);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1061, 606);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(144, 44);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSua.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(911, 606);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(144, 44);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(761, 606);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(144, 44);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbDanhSachDocGia
            // 
            this.lbDanhSachDocGia.AutoSize = true;
            this.lbDanhSachDocGia.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachDocGia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDanhSachDocGia.Location = new System.Drawing.Point(6, 0);
            this.lbDanhSachDocGia.Name = "lbDanhSachDocGia";
            this.lbDanhSachDocGia.Size = new System.Drawing.Size(279, 37);
            this.lbDanhSachDocGia.TabIndex = 1;
            this.lbDanhSachDocGia.Text = "Danh Sách Độc Giả";
            // 
            // dtgvDocGia
            // 
            this.dtgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDocGia.Location = new System.Drawing.Point(0, 98);
            this.dtgvDocGia.Name = "dtgvDocGia";
            this.dtgvDocGia.ReadOnly = true;
            this.dtgvDocGia.RowHeadersWidth = 51;
            this.dtgvDocGia.RowTemplate.Height = 24;
            this.dtgvDocGia.Size = new System.Drawing.Size(1352, 549);
            this.dtgvDocGia.TabIndex = 0;
            this.dtgvDocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDocGia_CellClick);
            // 
            // FDanhSachDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 653);
            this.Controls.Add(this.panelNen);
            this.Name = "FDanhSachDocGia";
            this.Text = "FDanhSachDocGia";
            this.Load += new System.EventHandler(this.FDanhSachDocGia_Load);
            this.panelNen.ResumeLayout(false);
            this.panelNen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDocGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNen;
        private System.Windows.Forms.Label lbDanhSachDocGia;
        private System.Windows.Forms.DataGridView dtgvDocGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTenDocGia;
        private System.Windows.Forms.Label lbTenSach;
    }
}