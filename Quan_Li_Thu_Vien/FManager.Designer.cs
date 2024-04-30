namespace Quan_Li_Thu_Vien
{
    partial class FManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_EmpID = new System.Windows.Forms.TextBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSach = new System.Windows.Forms.Button();
            this.btnNhapSach = new System.Windows.Forms.Button();
            this.btnMuonSach = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 51);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.label5.Location = new System.Drawing.Point(536, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nhân viên chưa có tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo tài khoản với tư cách quản lý";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên người dùng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã nhân viên";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(406, 348);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(302, 27);
            this.txt_UserName.TabIndex = 3;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(406, 410);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(302, 27);
            this.txt_Password.TabIndex = 4;
            // 
            // txt_EmpID
            // 
            this.txt_EmpID.Location = new System.Drawing.Point(406, 479);
            this.txt_EmpID.Name = "txt_EmpID";
            this.txt_EmpID.Size = new System.Drawing.Size(302, 27);
            this.txt_EmpID.TabIndex = 5;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(596, 523);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(97, 46);
            this.btn_Remove.TabIndex = 7;
            this.btn_Remove.Text = "Xóa";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(493, 523);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(97, 46);
            this.btn_Edit.TabIndex = 8;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSach);
            this.panel2.Controls.Add(this.btnNhapSach);
            this.panel2.Controls.Add(this.btnMuonSach);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btn_Edit);
            this.panel2.Controls.Add(this.btn_Remove);
            this.panel2.Controls.Add(this.txt_EmpID);
            this.panel2.Controls.Add(this.txt_Password);
            this.panel2.Controls.Add(this.txt_UserName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 572);
            this.panel2.TabIndex = 1;
            // 
            // btnSach
            // 
            this.btnSach.Location = new System.Drawing.Point(216, 523);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(97, 46);
            this.btnSach.TabIndex = 14;
            this.btnSach.Text = "Sách";
            this.btnSach.UseVisualStyleBackColor = true;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // btnNhapSach
            // 
            this.btnNhapSach.Location = new System.Drawing.Point(113, 523);
            this.btnNhapSach.Name = "btnNhapSach";
            this.btnNhapSach.Size = new System.Drawing.Size(97, 46);
            this.btnNhapSach.TabIndex = 13;
            this.btnNhapSach.Text = "Nhập Sách";
            this.btnNhapSach.UseVisualStyleBackColor = true;
            this.btnNhapSach.Click += new System.EventHandler(this.btnNhapSach_Click);
            // 
            // btnMuonSach
            // 
            this.btnMuonSach.Location = new System.Drawing.Point(12, 523);
            this.btnMuonSach.Name = "btnMuonSach";
            this.btnMuonSach.Size = new System.Drawing.Size(97, 46);
            this.btnMuonSach.TabIndex = 12;
            this.btnMuonSach.Text = "Mượn Sách";
            this.btnMuonSach.UseVisualStyleBackColor = true;
            this.btnMuonSach.Click += new System.EventHandler(this.btnMuonSach_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(541, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(400, 323);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(513, 323);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 623);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FManager";
            this.Load += new System.EventHandler(this.FManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_EmpID;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button btnNhapSach;
        private System.Windows.Forms.Button btnMuonSach;
    }
}