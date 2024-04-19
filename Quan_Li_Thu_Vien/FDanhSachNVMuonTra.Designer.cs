namespace Quan_Li_Thu_Vien
{
    partial class FDanhSachNVMuonTra
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
            this.lbDanhSachNVToMuonTra = new System.Windows.Forms.Label();
            this.dtgvNVToMuonTra = new System.Windows.Forms.DataGridView();
            this.panelNen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNVToMuonTra)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNen
            // 
            this.panelNen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNen.Controls.Add(this.lbDanhSachNVToMuonTra);
            this.panelNen.Controls.Add(this.dtgvNVToMuonTra);
            this.panelNen.Location = new System.Drawing.Point(2, 2);
            this.panelNen.Name = "panelNen";
            this.panelNen.Size = new System.Drawing.Size(1354, 650);
            this.panelNen.TabIndex = 5;
            // 
            // lbDanhSachNVToMuonTra
            // 
            this.lbDanhSachNVToMuonTra.AutoSize = true;
            this.lbDanhSachNVToMuonTra.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachNVToMuonTra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDanhSachNVToMuonTra.Location = new System.Drawing.Point(6, 0);
            this.lbDanhSachNVToMuonTra.Name = "lbDanhSachNVToMuonTra";
            this.lbDanhSachNVToMuonTra.Size = new System.Drawing.Size(505, 37);
            this.lbDanhSachNVToMuonTra.TabIndex = 1;
            this.lbDanhSachNVToMuonTra.Text = "Danh Sách Nhân Viên Tổ Mượn Trả";
            // 
            // dtgvNVToMuonTra
            // 
            this.dtgvNVToMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNVToMuonTra.Location = new System.Drawing.Point(0, 98);
            this.dtgvNVToMuonTra.Name = "dtgvNVToMuonTra";
            this.dtgvNVToMuonTra.ReadOnly = true;
            this.dtgvNVToMuonTra.RowHeadersWidth = 51;
            this.dtgvNVToMuonTra.RowTemplate.Height = 24;
            this.dtgvNVToMuonTra.Size = new System.Drawing.Size(1352, 549);
            this.dtgvNVToMuonTra.TabIndex = 0;
            // 
            // FDanhSachNVMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 653);
            this.Controls.Add(this.panelNen);
            this.Name = "FDanhSachNVMuonTra";
            this.Text = "FDanhSachNVMuonTra";
            this.Load += new System.EventHandler(this.FDanhSachNVMuonTra_Load);
            this.panelNen.ResumeLayout(false);
            this.panelNen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNVToMuonTra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNen;
        private System.Windows.Forms.Label lbDanhSachNVToMuonTra;
        private System.Windows.Forms.DataGridView dtgvNVToMuonTra;
    }
}