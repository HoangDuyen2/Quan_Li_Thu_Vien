namespace Quan_Li_Thu_Vien
{
    partial class FDanhSachNhaCungCap
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
            this.panelNen = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTenNCCNhap = new System.Windows.Forms.TextBox();
            this.lbTenTGTK = new System.Windows.Forms.Label();
            this.lbDanhSachNhanVienTrongTo = new System.Windows.Forms.Label();
            this.dtgvTG = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.panelNen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTG)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1247, 650);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 44);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelNen
            // 
            this.panelNen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNen.Controls.Add(this.btnTimKiem);
            this.panelNen.Controls.Add(this.txtTenNCCNhap);
            this.panelNen.Controls.Add(this.lbTenTGTK);
            this.panelNen.Controls.Add(this.lbDanhSachNhanVienTrongTo);
            this.panelNen.Controls.Add(this.dtgvTG);
            this.panelNen.Location = new System.Drawing.Point(0, 1);
            this.panelNen.Name = "panelNen";
            this.panelNen.Size = new System.Drawing.Size(1356, 650);
            this.panelNen.TabIndex = 15;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(1238, 71);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(109, 36);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTenNCCNhap
            // 
            this.txtTenNCCNhap.Location = new System.Drawing.Point(929, 71);
            this.txtTenNCCNhap.Multiline = true;
            this.txtTenNCCNhap.Name = "txtTenNCCNhap";
            this.txtTenNCCNhap.Size = new System.Drawing.Size(288, 30);
            this.txtTenNCCNhap.TabIndex = 4;
            // 
            // lbTenTGTK
            // 
            this.lbTenTGTK.AutoSize = true;
            this.lbTenTGTK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTenTGTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTGTK.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbTenTGTK.Location = new System.Drawing.Point(730, 76);
            this.lbTenTGTK.Name = "lbTenTGTK";
            this.lbTenTGTK.Size = new System.Drawing.Size(173, 25);
            this.lbTenTGTK.TabIndex = 3;
            this.lbTenTGTK.Text = "Tên Nhà cung cấp";
            // 
            // lbDanhSachNhanVienTrongTo
            // 
            this.lbDanhSachNhanVienTrongTo.AutoSize = true;
            this.lbDanhSachNhanVienTrongTo.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachNhanVienTrongTo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDanhSachNhanVienTrongTo.Location = new System.Drawing.Point(3, 8);
            this.lbDanhSachNhanVienTrongTo.Name = "lbDanhSachNhanVienTrongTo";
            this.lbDanhSachNhanVienTrongTo.Size = new System.Drawing.Size(408, 37);
            this.lbDanhSachNhanVienTrongTo.TabIndex = 1;
            this.lbDanhSachNhanVienTrongTo.Text = "Danh sách các nhà cung cấp";
            // 
            // dtgvTG
            // 
            this.dtgvTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTG.Location = new System.Drawing.Point(0, 123);
            this.dtgvTG.Name = "dtgvTG";
            this.dtgvTG.RowHeadersWidth = 51;
            this.dtgvTG.RowTemplate.Height = 24;
            this.dtgvTG.Size = new System.Drawing.Size(1355, 527);
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
            this.btnThem.Location = new System.Drawing.Point(1138, 650);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 44);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Add";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FDanhSachNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 695);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelNen);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDanhSachNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDanhSachNhaCungCap";
            this.Load += new System.EventHandler(this.FDanhSachNhaCungCap_Load);
            this.panelNen.ResumeLayout(false);
            this.panelNen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelNen;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTenNCCNhap;
        private System.Windows.Forms.Label lbTenTGTK;
        private System.Windows.Forms.Label lbDanhSachNhanVienTrongTo;
        private System.Windows.Forms.DataGridView dtgvTG;
        private System.Windows.Forms.Button btnThem;
    }
}