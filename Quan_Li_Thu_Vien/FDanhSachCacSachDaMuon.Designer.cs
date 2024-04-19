namespace Quan_Li_Thu_Vien
{
    partial class FDanhSachCacSachDaMuon
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
            this.lbDanhSachCacSachDaMuon = new System.Windows.Forms.Label();
            this.dtgvSachDaMuon = new System.Windows.Forms.DataGridView();
            this.panelNen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSachDaMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNen
            // 
            this.panelNen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNen.Controls.Add(this.lbDanhSachCacSachDaMuon);
            this.panelNen.Controls.Add(this.dtgvSachDaMuon);
            this.panelNen.Location = new System.Drawing.Point(-1, 6);
            this.panelNen.Name = "panelNen";
            this.panelNen.Size = new System.Drawing.Size(1354, 650);
            this.panelNen.TabIndex = 5;
            // 
            // lbDanhSachCacSachDaMuon
            // 
            this.lbDanhSachCacSachDaMuon.AutoSize = true;
            this.lbDanhSachCacSachDaMuon.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachCacSachDaMuon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDanhSachCacSachDaMuon.Location = new System.Drawing.Point(6, 0);
            this.lbDanhSachCacSachDaMuon.Name = "lbDanhSachCacSachDaMuon";
            this.lbDanhSachCacSachDaMuon.Size = new System.Drawing.Size(433, 37);
            this.lbDanhSachCacSachDaMuon.TabIndex = 1;
            this.lbDanhSachCacSachDaMuon.Text = "Danh Sách Các Sánh Đã Mượn";
            // 
            // dtgvSachDaMuon
            // 
            this.dtgvSachDaMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSachDaMuon.Location = new System.Drawing.Point(0, 98);
            this.dtgvSachDaMuon.Name = "dtgvSachDaMuon";
            this.dtgvSachDaMuon.ReadOnly = true;
            this.dtgvSachDaMuon.RowHeadersWidth = 51;
            this.dtgvSachDaMuon.RowTemplate.Height = 24;
            this.dtgvSachDaMuon.Size = new System.Drawing.Size(1352, 549);
            this.dtgvSachDaMuon.TabIndex = 0;
            // 
            // FDanhSachCacSachDaMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 659);
            this.Controls.Add(this.panelNen);
            this.Name = "FDanhSachCacSachDaMuon";
            this.Text = "FDanhSachCacSachDaMuon";
            this.Load += new System.EventHandler(this.FDanhSachCacSachDaMuon_Load);
            this.panelNen.ResumeLayout(false);
            this.panelNen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSachDaMuon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNen;
        private System.Windows.Forms.Label lbDanhSachCacSachDaMuon;
        private System.Windows.Forms.DataGridView dtgvSachDaMuon;
    }
}