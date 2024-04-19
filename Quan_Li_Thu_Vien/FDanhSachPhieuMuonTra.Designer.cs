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
            this.lbDanhSachCacCuonSach = new System.Windows.Forms.Label();
            this.dtgvPhieuMuonTra = new System.Windows.Forms.DataGridView();
            this.panelNen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuMuonTra)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNen
            // 
            this.panelNen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNen.Controls.Add(this.lbDanhSachCacCuonSach);
            this.panelNen.Controls.Add(this.dtgvPhieuMuonTra);
            this.panelNen.Location = new System.Drawing.Point(0, 0);
            this.panelNen.Name = "panelNen";
            this.panelNen.Size = new System.Drawing.Size(1354, 650);
            this.panelNen.TabIndex = 3;
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
            // 
            // FDanhSachPhieuMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 655);
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
    }
}