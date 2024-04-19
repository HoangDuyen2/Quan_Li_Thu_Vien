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
            this.lbDanhSachDocGia = new System.Windows.Forms.Label();
            this.dtgvDocGia = new System.Windows.Forms.DataGridView();
            this.panelNen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNen
            // 
            this.panelNen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNen.Controls.Add(this.lbDanhSachDocGia);
            this.panelNen.Controls.Add(this.dtgvDocGia);
            this.panelNen.Location = new System.Drawing.Point(1, 3);
            this.panelNen.Name = "panelNen";
            this.panelNen.Size = new System.Drawing.Size(1354, 650);
            this.panelNen.TabIndex = 4;
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
    }
}