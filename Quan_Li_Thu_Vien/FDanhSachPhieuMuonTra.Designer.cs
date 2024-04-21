namespace Quan_Li_Thu_Vien
{
    partial class FDanhSachPhieuMuonTra
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbDanhSachCacCuonSach = new System.Windows.Forms.Label();
            this.dtgvPhieuMuonTra = new System.Windows.Forms.DataGridView();
            this.panelNen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuMuonTra)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNen
            // 
            this.panelNen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNen.Controls.Add(this.btnXoa);
            this.panelNen.Controls.Add(this.btnThem);
            this.panelNen.Controls.Add(this.lbDanhSachCacCuonSach);
            this.panelNen.Controls.Add(this.dtgvPhieuMuonTra);
            this.panelNen.Location = new System.Drawing.Point(0, 0);
            this.panelNen.Name = "panelNen";
            this.panelNen.Size = new System.Drawing.Size(1354, 650);
            this.panelNen.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1068, 606);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(144, 44);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(918, 606);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(144, 44);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbDanhSachCacCuonSach
            // 
            this.lbDanhSachCacCuonSach.AutoSize = true;
            this.lbDanhSachCacCuonSach.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachCacCuonSach.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDanhSachCacCuonSach.Location = new System.Drawing.Point(6, 0);
            this.lbDanhSachCacCuonSach.Name = "lbDanhSachCacCuonSach";
            this.lbDanhSachCacCuonSach.Size = new System.Drawing.Size(395, 37);
            this.lbDanhSachCacCuonSach.TabIndex = 1;
            this.lbDanhSachCacCuonSach.Text = "Danh Sách Phiếu Mượn Trả";
            // 
            // dtgvPhieuMuonTra
            // 
            this.dtgvPhieuMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhieuMuonTra.Location = new System.Drawing.Point(0, 98);
            this.dtgvPhieuMuonTra.Name = "dtgvPhieuMuonTra";
            this.dtgvPhieuMuonTra.ReadOnly = true;
            this.dtgvPhieuMuonTra.RowHeadersWidth = 51;
            this.dtgvPhieuMuonTra.RowTemplate.Height = 24;
            this.dtgvPhieuMuonTra.Size = new System.Drawing.Size(1352, 549);
            this.dtgvPhieuMuonTra.TabIndex = 0;
            this.dtgvPhieuMuonTra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPhieuMuonTra_CellClick);
            // 
            // FDanhSachPhieuMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 651);
            this.Controls.Add(this.panelNen);
            this.Name = "FDanhSachPhieuMuonTra";
            this.Text = "FDanhSachPhieuMuonTra";
            this.Load += new System.EventHandler(this.FDanhSachPhieuMuonTra_Load);
            this.panelNen.ResumeLayout(false);
            this.panelNen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuMuonTra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelNen;
        private System.Windows.Forms.Label lbDanhSachCacCuonSach;
        private System.Windows.Forms.DataGridView dtgvPhieuMuonTra;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
    }
}