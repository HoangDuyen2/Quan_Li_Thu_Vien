namespace Quan_Li_Thu_Vien
{
    partial class FDanhSachCacSachBiHu
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
            this.lbDanhSachCacCuonSachBiHu = new System.Windows.Forms.Label();
            this.dtgvSachBiHu = new System.Windows.Forms.DataGridView();
            this.panelNen = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSachBiHu)).BeginInit();
            this.panelNen.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1247, 646);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 44);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbDanhSachCacCuonSachBiHu
            // 
            this.lbDanhSachCacCuonSachBiHu.AutoSize = true;
            this.lbDanhSachCacCuonSachBiHu.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachCacCuonSachBiHu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDanhSachCacCuonSachBiHu.Location = new System.Drawing.Point(3, 12);
            this.lbDanhSachCacCuonSachBiHu.Name = "lbDanhSachCacCuonSachBiHu";
            this.lbDanhSachCacCuonSachBiHu.Size = new System.Drawing.Size(436, 37);
            this.lbDanhSachCacCuonSachBiHu.TabIndex = 1;
            this.lbDanhSachCacCuonSachBiHu.Text = "Danh sách các cuốn sách bị hư";
            // 
            // dtgvSachBiHu
            // 
            this.dtgvSachBiHu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSachBiHu.Location = new System.Drawing.Point(1, 99);
            this.dtgvSachBiHu.Name = "dtgvSachBiHu";
            this.dtgvSachBiHu.RowHeadersWidth = 51;
            this.dtgvSachBiHu.RowTemplate.Height = 24;
            this.dtgvSachBiHu.Size = new System.Drawing.Size(1355, 549);
            this.dtgvSachBiHu.TabIndex = 0;
            this.dtgvSachBiHu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSachBiHu_CellContentClick);
            // 
            // panelNen
            // 
            this.panelNen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNen.Controls.Add(this.lbDanhSachCacCuonSachBiHu);
            this.panelNen.Controls.Add(this.dtgvSachBiHu);
            this.panelNen.Location = new System.Drawing.Point(-1, -1);
            this.panelNen.Name = "panelNen";
            this.panelNen.Size = new System.Drawing.Size(1355, 649);
            this.panelNen.TabIndex = 2;
            // 
            // FDanhSachCacSachBiHu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 690);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDanhSachCacSachBiHu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDanhSachCacSachBiHu";
            this.Load += new System.EventHandler(this.FDanhSachCacSachBiHu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSachBiHu)).EndInit();
            this.panelNen.ResumeLayout(false);
            this.panelNen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbDanhSachCacCuonSachBiHu;
        private System.Windows.Forms.DataGridView dtgvSachBiHu;
        private System.Windows.Forms.Panel panelNen;
    }
}