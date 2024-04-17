namespace Quan_Li_Thu_Vien
{
    partial class FDanhSachCacNhaXuatBan
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
            this.dtgvSach = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbDanhSachCacNXB = new System.Windows.Forms.Label();
            this.panelNen = new System.Windows.Forms.Panel();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.lbTenNXB = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).BeginInit();
            this.panelNen.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvSach
            // 
            this.dtgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSach.Location = new System.Drawing.Point(0, 100);
            this.dtgvSach.Name = "dtgvSach";
            this.dtgvSach.ReadOnly = true;
            this.dtgvSach.RowHeadersWidth = 51;
            this.dtgvSach.RowTemplate.Height = 24;
            this.dtgvSach.Size = new System.Drawing.Size(1355, 549);
            this.dtgvSach.TabIndex = 0;
            this.dtgvSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSach_CellContentClick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1245, 648);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 44);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbDanhSachCacNXB
            // 
            this.lbDanhSachCacNXB.AutoSize = true;
            this.lbDanhSachCacNXB.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachCacNXB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDanhSachCacNXB.Location = new System.Drawing.Point(-4, 0);
            this.lbDanhSachCacNXB.Name = "lbDanhSachCacNXB";
            this.lbDanhSachCacNXB.Size = new System.Drawing.Size(406, 37);
            this.lbDanhSachCacNXB.TabIndex = 1;
            this.lbDanhSachCacNXB.Text = "Danh sách các nhà xuất bản";
            // 
            // panelNen
            // 
            this.panelNen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNen.Controls.Add(this.txtTenNXB);
            this.panelNen.Controls.Add(this.lbTenNXB);
            this.panelNen.Controls.Add(this.btnTimKiem);
            this.panelNen.Controls.Add(this.lbDanhSachCacNXB);
            this.panelNen.Controls.Add(this.dtgvSach);
            this.panelNen.Location = new System.Drawing.Point(-1, -1);
            this.panelNen.Name = "panelNen";
            this.panelNen.Size = new System.Drawing.Size(1355, 649);
            this.panelNen.TabIndex = 4;
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(953, 53);
            this.txtTenNXB.Multiline = true;
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(258, 30);
            this.txtTenNXB.TabIndex = 18;
            // 
            // lbTenNXB
            // 
            this.lbTenNXB.AutoSize = true;
            this.lbTenNXB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTenNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNXB.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbTenNXB.Location = new System.Drawing.Point(771, 53);
            this.lbTenNXB.Name = "lbTenNXB";
            this.lbTenNXB.Size = new System.Drawing.Size(165, 25);
            this.lbTenNXB.TabIndex = 13;
            this.lbTenNXB.Text = "Tên nhà xuất bản";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(1233, 53);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(109, 36);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // FDanhSachCacNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 690);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDanhSachCacNhaXuatBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDanhSachCacNhaXuatBan";
            this.Load += new System.EventHandler(this.FDanhSachCacNhaXuatBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).EndInit();
            this.panelNen.ResumeLayout(false);
            this.panelNen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvSach;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbDanhSachCacNXB;
        private System.Windows.Forms.Panel panelNen;
        private System.Windows.Forms.Label lbTenNXB;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTenNXB;
    }
}