namespace Quan_Li_Thu_Vien
{
    partial class FDanhSachCacSach
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
            this.lbNgonNguSearch = new System.Windows.Forms.Label();
            this.comboBoxNgonNgu = new System.Windows.Forms.ComboBox();
            this.lbLoaiSachSearch = new System.Windows.Forms.Label();
            this.comboBoxLoaiSach = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.lbTenSach = new System.Windows.Forms.Label();
            this.lbDanhSachCacCuonSach = new System.Windows.Forms.Label();
            this.dtgvSach = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelNen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNen
            // 
            this.panelNen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNen.Controls.Add(this.lbNgonNguSearch);
            this.panelNen.Controls.Add(this.comboBoxNgonNgu);
            this.panelNen.Controls.Add(this.lbLoaiSachSearch);
            this.panelNen.Controls.Add(this.comboBoxLoaiSach);
            this.panelNen.Controls.Add(this.btnTimKiem);
            this.panelNen.Controls.Add(this.txtTenSach);
            this.panelNen.Controls.Add(this.lbTenSach);
            this.panelNen.Controls.Add(this.lbDanhSachCacCuonSach);
            this.panelNen.Controls.Add(this.dtgvSach);
            this.panelNen.Location = new System.Drawing.Point(-1, -1);
            this.panelNen.Name = "panelNen";
            this.panelNen.Size = new System.Drawing.Size(1354, 650);
            this.panelNen.TabIndex = 0;
            // 
            // lbNgonNguSearch
            // 
            this.lbNgonNguSearch.AutoSize = true;
            this.lbNgonNguSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbNgonNguSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgonNguSearch.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbNgonNguSearch.Location = new System.Drawing.Point(426, 60);
            this.lbNgonNguSearch.Name = "lbNgonNguSearch";
            this.lbNgonNguSearch.Size = new System.Drawing.Size(97, 25);
            this.lbNgonNguSearch.TabIndex = 12;
            this.lbNgonNguSearch.Text = "Ngôn ngữ";
            // 
            // comboBoxNgonNgu
            // 
            this.comboBoxNgonNgu.FormattingEnabled = true;
            this.comboBoxNgonNgu.Location = new System.Drawing.Point(541, 61);
            this.comboBoxNgonNgu.Name = "comboBoxNgonNgu";
            this.comboBoxNgonNgu.Size = new System.Drawing.Size(178, 24);
            this.comboBoxNgonNgu.TabIndex = 11;
            this.comboBoxNgonNgu.SelectedIndexChanged += new System.EventHandler(this.comboBoxNgonNgu_SelectedIndexChanged);
            // 
            // lbLoaiSachSearch
            // 
            this.lbLoaiSachSearch.AutoSize = true;
            this.lbLoaiSachSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbLoaiSachSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiSachSearch.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbLoaiSachSearch.Location = new System.Drawing.Point(35, 61);
            this.lbLoaiSachSearch.Name = "lbLoaiSachSearch";
            this.lbLoaiSachSearch.Size = new System.Drawing.Size(96, 25);
            this.lbLoaiSachSearch.TabIndex = 10;
            this.lbLoaiSachSearch.Text = "Loại sách";
            // 
            // comboBoxLoaiSach
            // 
            this.comboBoxLoaiSach.FormattingEnabled = true;
            this.comboBoxLoaiSach.Location = new System.Drawing.Point(146, 63);
            this.comboBoxLoaiSach.Name = "comboBoxLoaiSach";
            this.comboBoxLoaiSach.Size = new System.Drawing.Size(215, 24);
            this.comboBoxLoaiSach.TabIndex = 9;
            this.comboBoxLoaiSach.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoaiSach_SelectedIndexChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(1222, 55);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(109, 36);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(944, 60);
            this.txtTenSach.Multiline = true;
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(258, 30);
            this.txtTenSach.TabIndex = 7;
            // 
            // lbTenSach
            // 
            this.lbTenSach.AutoSize = true;
            this.lbTenSach.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSach.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbTenSach.Location = new System.Drawing.Point(803, 61);
            this.lbTenSach.Name = "lbTenSach";
            this.lbTenSach.Size = new System.Drawing.Size(98, 25);
            this.lbTenSach.TabIndex = 6;
            this.lbTenSach.Text = "Tên Sách";
            // 
            // lbDanhSachCacCuonSach
            // 
            this.lbDanhSachCacCuonSach.AutoSize = true;
            this.lbDanhSachCacCuonSach.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachCacCuonSach.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDanhSachCacCuonSach.Location = new System.Drawing.Point(-3, -1);
            this.lbDanhSachCacCuonSach.Name = "lbDanhSachCacCuonSach";
            this.lbDanhSachCacCuonSach.Size = new System.Drawing.Size(358, 37);
            this.lbDanhSachCacCuonSach.TabIndex = 1;
            this.lbDanhSachCacCuonSach.Text = "Danh sách các cuốn sách";
            // 
            // dtgvSach
            // 
            this.dtgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSach.Location = new System.Drawing.Point(2, 101);
            this.dtgvSach.Name = "dtgvSach";
            this.dtgvSach.ReadOnly = true;
            this.dtgvSach.RowHeadersWidth = 51;
            this.dtgvSach.RowTemplate.Height = 24;
            this.dtgvSach.Size = new System.Drawing.Size(1352, 549);
            this.dtgvSach.TabIndex = 0;
            this.dtgvSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSach_CellContentClick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1244, 646);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 44);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1102, 646);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 44);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm sách";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FDanhSachCacSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 690);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDanhSachCacSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDanhSachCacSach";
            this.Load += new System.EventHandler(this.FDanhSachCacSach_Load);
            this.panelNen.ResumeLayout(false);
            this.panelNen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNen;
        private System.Windows.Forms.DataGridView dtgvSach;
        private System.Windows.Forms.Label lbDanhSachCacCuonSach;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbNgonNguSearch;
        private System.Windows.Forms.ComboBox comboBoxNgonNgu;
        private System.Windows.Forms.Label lbLoaiSachSearch;
        private System.Windows.Forms.ComboBox comboBoxLoaiSach;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label lbTenSach;
        private System.Windows.Forms.Button btnAdd;
    }
}