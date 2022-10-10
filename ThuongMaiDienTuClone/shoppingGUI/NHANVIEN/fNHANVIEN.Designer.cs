namespace shoppingGUI.NHANVIEN
{
    partial class fNHANVIEN
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSDTNV = new System.Windows.Forms.TextBox();
            this.cbGioiTinhNV = new System.Windows.Forms.ComboBox();
            this.dtpNGSINHNV = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTenNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMANV = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachNV = new System.Windows.Forms.DataGridView();
            this.btnAddNV = new System.Windows.Forms.Button();
            this.btnUpdateNV = new System.Windows.Forms.Button();
            this.btnDeleteNV = new System.Windows.Forms.Button();
            this.btnCancelChangeNV = new System.Windows.Forms.Button();
            this.btnSaveChangesNV = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSDTNV);
            this.groupBox1.Controls.Add(this.cbGioiTinhNV);
            this.groupBox1.Controls.Add(this.dtpNGSINHNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbTenNV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbMANV);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // tbSDTNV
            // 
            this.tbSDTNV.Location = new System.Drawing.Point(164, 89);
            this.tbSDTNV.Name = "tbSDTNV";
            this.tbSDTNV.Size = new System.Drawing.Size(266, 20);
            this.tbSDTNV.TabIndex = 13;
            // 
            // cbGioiTinhNV
            // 
            this.cbGioiTinhNV.FormattingEnabled = true;
            this.cbGioiTinhNV.Location = new System.Drawing.Point(501, 39);
            this.cbGioiTinhNV.Name = "cbGioiTinhNV";
            this.cbGioiTinhNV.Size = new System.Drawing.Size(121, 21);
            this.cbGioiTinhNV.TabIndex = 12;
            // 
            // dtpNGSINHNV
            // 
            this.dtpNGSINHNV.Location = new System.Drawing.Point(501, 89);
            this.dtpNGSINHNV.Name = "dtpNGSINHNV";
            this.dtpNGSINHNV.Size = new System.Drawing.Size(266, 20);
            this.dtpNGSINHNV.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên nhân viên";
            // 
            // tbTenNV
            // 
            this.tbTenNV.Location = new System.Drawing.Point(163, 40);
            this.tbTenNV.Name = "tbTenNV";
            this.tbTenNV.Size = new System.Drawing.Size(266, 20);
            this.tbTenNV.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên";
            // 
            // tbMANV
            // 
            this.tbMANV.Location = new System.Drawing.Point(27, 68);
            this.tbMANV.Name = "tbMANV";
            this.tbMANV.Size = new System.Drawing.Size(67, 20);
            this.tbMANV.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSachNV);
            this.groupBox2.Location = new System.Drawing.Point(13, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 317);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // dgvDanhSachNV
            // 
            this.dgvDanhSachNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNV.Location = new System.Drawing.Point(6, 19);
            this.dgvDanhSachNV.Name = "dgvDanhSachNV";
            this.dgvDanhSachNV.Size = new System.Drawing.Size(830, 292);
            this.dgvDanhSachNV.TabIndex = 0;
            // 
            // btnAddNV
            // 
            this.btnAddNV.Location = new System.Drawing.Point(176, 155);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(75, 23);
            this.btnAddNV.TabIndex = 3;
            this.btnAddNV.Text = "Thêm";
            this.btnAddNV.UseVisualStyleBackColor = true;
            this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
            // 
            // btnUpdateNV
            // 
            this.btnUpdateNV.Location = new System.Drawing.Point(383, 155);
            this.btnUpdateNV.Name = "btnUpdateNV";
            this.btnUpdateNV.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateNV.TabIndex = 5;
            this.btnUpdateNV.Text = "Sửa";
            this.btnUpdateNV.UseVisualStyleBackColor = true;
            this.btnUpdateNV.Click += new System.EventHandler(this.btnUpdateNV_Click);
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.Location = new System.Drawing.Point(280, 155);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteNV.TabIndex = 4;
            this.btnDeleteNV.Text = "Xóa";
            this.btnDeleteNV.UseVisualStyleBackColor = true;
            this.btnDeleteNV.Click += new System.EventHandler(this.btnDeleteNV_Click);
            // 
            // btnCancelChangeNV
            // 
            this.btnCancelChangeNV.Location = new System.Drawing.Point(586, 155);
            this.btnCancelChangeNV.Name = "btnCancelChangeNV";
            this.btnCancelChangeNV.Size = new System.Drawing.Size(75, 23);
            this.btnCancelChangeNV.TabIndex = 7;
            this.btnCancelChangeNV.Text = "Hủy";
            this.btnCancelChangeNV.UseVisualStyleBackColor = true;
            this.btnCancelChangeNV.Click += new System.EventHandler(this.btnCancelChangeNV_Click);
            // 
            // btnSaveChangesNV
            // 
            this.btnSaveChangesNV.Location = new System.Drawing.Point(483, 155);
            this.btnSaveChangesNV.Name = "btnSaveChangesNV";
            this.btnSaveChangesNV.Size = new System.Drawing.Size(75, 23);
            this.btnSaveChangesNV.TabIndex = 6;
            this.btnSaveChangesNV.Text = "Lưu";
            this.btnSaveChangesNV.UseVisualStyleBackColor = true;
            this.btnSaveChangesNV.Click += new System.EventHandler(this.btnSaveChangesNV_Click);
            // 
            // fNHANVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 503);
            this.Controls.Add(this.btnCancelChangeNV);
            this.Controls.Add(this.btnSaveChangesNV);
            this.Controls.Add(this.btnUpdateNV);
            this.Controls.Add(this.btnDeleteNV);
            this.Controls.Add(this.btnAddNV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "fNHANVIEN";
            this.Text = "fNHANVIEN";
            this.Load += new System.EventHandler(this.fNHANVIEN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTenNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMANV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDanhSachNV;
        private System.Windows.Forms.DateTimePicker dtpNGSINHNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddNV;
        private System.Windows.Forms.Button btnUpdateNV;
        private System.Windows.Forms.Button btnDeleteNV;
        private System.Windows.Forms.Button btnCancelChangeNV;
        private System.Windows.Forms.Button btnSaveChangesNV;
        private System.Windows.Forms.ComboBox cbGioiTinhNV;
        private System.Windows.Forms.TextBox tbSDTNV;
    }
}