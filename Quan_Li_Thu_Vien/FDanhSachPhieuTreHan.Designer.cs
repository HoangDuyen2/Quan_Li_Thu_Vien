namespace Quan_Li_Thu_Vien
{
    partial class FDanhSachPhieuTreHan
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
            this.lbDanhSachPhieuTreHan = new System.Windows.Forms.Label();
            this.dtgvPhieuTreHan = new System.Windows.Forms.DataGridView();
            this.panelNen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuTreHan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNen
            // 
            this.panelNen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNen.Controls.Add(this.lbDanhSachPhieuTreHan);
            this.panelNen.Controls.Add(this.dtgvPhieuTreHan);
            this.panelNen.Location = new System.Drawing.Point(2, 3);
            this.panelNen.Name = "panelNen";
            this.panelNen.Size = new System.Drawing.Size(1354, 650);
            this.panelNen.TabIndex = 4;
            // 
            // lbDanhSachPhieuTreHan
            // 
            this.lbDanhSachPhieuTreHan.AutoSize = true;
            this.lbDanhSachPhieuTreHan.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachPhieuTreHan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDanhSachPhieuTreHan.Location = new System.Drawing.Point(6, 0);
            this.lbDanhSachPhieuTreHan.Name = "lbDanhSachPhieuTreHan";
            this.lbDanhSachPhieuTreHan.Size = new System.Drawing.Size(372, 37);
            this.lbDanhSachPhieuTreHan.TabIndex = 1;
            this.lbDanhSachPhieuTreHan.Text = "Danh Sách Phiếu Trễ Hạn";
            // 
            // dtgvPhieuTreHan
            // 
            this.dtgvPhieuTreHan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhieuTreHan.Location = new System.Drawing.Point(0, 98);
            this.dtgvPhieuTreHan.Name = "dtgvPhieuTreHan";
            this.dtgvPhieuTreHan.ReadOnly = true;
            this.dtgvPhieuTreHan.RowHeadersWidth = 51;
            this.dtgvPhieuTreHan.RowTemplate.Height = 24;
            this.dtgvPhieuTreHan.Size = new System.Drawing.Size(1352, 549);
            this.dtgvPhieuTreHan.TabIndex = 0;
            // 
            // FDanhSachPhieuTreHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 658);
            this.Controls.Add(this.panelNen);
            this.Name = "FDanhSachPhieuTreHan";
            this.Text = "FDanhSachPhieuTreHan";
            this.Load += new System.EventHandler(this.FDanhSachPhieuTreHan_Load);
            this.panelNen.ResumeLayout(false);
            this.panelNen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuTreHan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNen;
        private System.Windows.Forms.Label lbDanhSachPhieuTreHan;
        private System.Windows.Forms.DataGridView dtgvPhieuTreHan;
    }
}