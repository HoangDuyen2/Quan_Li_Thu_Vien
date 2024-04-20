namespace Quan_Li_Thu_Vien
{
    partial class FDanhSachPhieuPhat
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
            this.lbDanhSachPhieuPhat = new System.Windows.Forms.Label();
            this.dtgvPhieuPhat = new System.Windows.Forms.DataGridView();
            this.panelNen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuPhat)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNen
            // 
            this.panelNen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNen.Controls.Add(this.lbDanhSachPhieuPhat);
            this.panelNen.Controls.Add(this.dtgvPhieuPhat);
            this.panelNen.Location = new System.Drawing.Point(1, 3);
            this.panelNen.Name = "panelNen";
            this.panelNen.Size = new System.Drawing.Size(1354, 650);
            this.panelNen.TabIndex = 5;
            // 
            // lbDanhSachPhieuPhat
            // 
            this.lbDanhSachPhieuPhat.AutoSize = true;
            this.lbDanhSachPhieuPhat.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachPhieuPhat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDanhSachPhieuPhat.Location = new System.Drawing.Point(6, 0);
            this.lbDanhSachPhieuPhat.Name = "lbDanhSachPhieuPhat";
            this.lbDanhSachPhieuPhat.Size = new System.Drawing.Size(324, 37);
            this.lbDanhSachPhieuPhat.TabIndex = 1;
            this.lbDanhSachPhieuPhat.Text = "Danh Sách Phiếu Phạt";
            // 
            // dtgvPhieuPhat
            // 
            this.dtgvPhieuPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhieuPhat.Location = new System.Drawing.Point(0, 98);
            this.dtgvPhieuPhat.Name = "dtgvPhieuPhat";
            this.dtgvPhieuPhat.ReadOnly = true;
            this.dtgvPhieuPhat.RowHeadersWidth = 51;
            this.dtgvPhieuPhat.RowTemplate.Height = 24;
            this.dtgvPhieuPhat.Size = new System.Drawing.Size(1352, 549);
            this.dtgvPhieuPhat.TabIndex = 0;
            // 
            // FDanhSachPhieuPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 654);
            this.Controls.Add(this.panelNen);
            this.Name = "FDanhSachPhieuPhat";
            this.Text = "FDanhSachPhieuPhat";
            this.Load += new System.EventHandler(this.FDanhSachPhieuPhat_Load);
            this.panelNen.ResumeLayout(false);
            this.panelNen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuPhat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNen;
        private System.Windows.Forms.Label lbDanhSachPhieuPhat;
        private System.Windows.Forms.DataGridView dtgvPhieuPhat;
    }
}