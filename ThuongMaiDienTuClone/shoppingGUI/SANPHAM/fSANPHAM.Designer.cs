namespace shoppingGUI.HANGHOA
{
    partial class fSANPHAM
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
            this.btnSaveChangesSP = new System.Windows.Forms.Button();
            this.btnUpdateSP = new System.Windows.Forms.Button();
            this.btnDeleteSP = new System.Windows.Forms.Button();
            this.btnAddSP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGiaSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTenSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMASP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachSP = new System.Windows.Forms.DataGridView();
            this.btnCancelChangeSP = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveChangesSP
            // 
            this.btnSaveChangesSP.Location = new System.Drawing.Point(400, 176);
            this.btnSaveChangesSP.Name = "btnSaveChangesSP";
            this.btnSaveChangesSP.Size = new System.Drawing.Size(75, 23);
            this.btnSaveChangesSP.TabIndex = 19;
            this.btnSaveChangesSP.Text = "Lưu";
            this.btnSaveChangesSP.UseVisualStyleBackColor = true;
            this.btnSaveChangesSP.Click += new System.EventHandler(this.btnSaveChangesSP_Click);
            // 
            // btnUpdateSP
            // 
            this.btnUpdateSP.Location = new System.Drawing.Point(300, 176);
            this.btnUpdateSP.Name = "btnUpdateSP";
            this.btnUpdateSP.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSP.TabIndex = 18;
            this.btnUpdateSP.Text = "Sửa";
            this.btnUpdateSP.UseVisualStyleBackColor = true;
            this.btnUpdateSP.Click += new System.EventHandler(this.btnUpdateSP_Click);
            // 
            // btnDeleteSP
            // 
            this.btnDeleteSP.Location = new System.Drawing.Point(197, 176);
            this.btnDeleteSP.Name = "btnDeleteSP";
            this.btnDeleteSP.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSP.TabIndex = 17;
            this.btnDeleteSP.Text = "Xóa";
            this.btnDeleteSP.UseVisualStyleBackColor = true;
            this.btnDeleteSP.Click += new System.EventHandler(this.btnDeleteSP_Click);
            // 
            // btnAddSP
            // 
            this.btnAddSP.Location = new System.Drawing.Point(93, 176);
            this.btnAddSP.Name = "btnAddSP";
            this.btnAddSP.Size = new System.Drawing.Size(75, 23);
            this.btnAddSP.TabIndex = 16;
            this.btnAddSP.Text = "Thêm";
            this.btnAddSP.UseVisualStyleBackColor = true;
            this.btnAddSP.Click += new System.EventHandler(this.btnAddSP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbLoaiSP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbGiaSP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbTenSP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbMASP);
            this.groupBox1.Location = new System.Drawing.Point(18, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 149);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "VND";
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.FormattingEnabled = true;
            this.cbLoaiSP.Location = new System.Drawing.Point(214, 50);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(130, 21);
            this.cbLoaiSP.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Loại sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giá sản phẩm";
            // 
            // tbGiaSP
            // 
            this.tbGiaSP.Location = new System.Drawing.Point(212, 99);
            this.tbGiaSP.Name = "tbGiaSP";
            this.tbGiaSP.Size = new System.Drawing.Size(190, 20);
            this.tbGiaSP.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sản phẩm";
            // 
            // tbTenSP
            // 
            this.tbTenSP.Location = new System.Drawing.Point(32, 99);
            this.tbTenSP.Name = "tbTenSP";
            this.tbTenSP.Size = new System.Drawing.Size(130, 20);
            this.tbTenSP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sản phẩm";
            // 
            // tbMASP
            // 
            this.tbMASP.Location = new System.Drawing.Point(32, 51);
            this.tbMASP.Name = "tbMASP";
            this.tbMASP.Size = new System.Drawing.Size(67, 20);
            this.tbMASP.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSachSP);
            this.groupBox2.Location = new System.Drawing.Point(12, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 276);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dgvDanhSachSP
            // 
            this.dgvDanhSachSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSP.Location = new System.Drawing.Point(6, 19);
            this.dgvDanhSachSP.Name = "dgvDanhSachSP";
            this.dgvDanhSachSP.Size = new System.Drawing.Size(622, 251);
            this.dgvDanhSachSP.TabIndex = 0;
            // 
            // btnCancelChangeSP
            // 
            this.btnCancelChangeSP.Location = new System.Drawing.Point(497, 176);
            this.btnCancelChangeSP.Name = "btnCancelChangeSP";
            this.btnCancelChangeSP.Size = new System.Drawing.Size(75, 23);
            this.btnCancelChangeSP.TabIndex = 20;
            this.btnCancelChangeSP.Text = "Hủy";
            this.btnCancelChangeSP.UseVisualStyleBackColor = true;
            this.btnCancelChangeSP.Click += new System.EventHandler(this.btnCancelChangeSP_Click);
            // 
            // fSANPHAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 495);
            this.Controls.Add(this.btnCancelChangeSP);
            this.Controls.Add(this.btnSaveChangesSP);
            this.Controls.Add(this.btnUpdateSP);
            this.Controls.Add(this.btnDeleteSP);
            this.Controls.Add(this.btnAddSP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "fSANPHAM";
            this.Text = "fHANGHOA";
            this.Load += new System.EventHandler(this.fSANPHAM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveChangesSP;
        private System.Windows.Forms.Button btnUpdateSP;
        private System.Windows.Forms.Button btnDeleteSP;
        private System.Windows.Forms.Button btnAddSP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGiaSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTenSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMASP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDanhSachSP;
        private System.Windows.Forms.Button btnCancelChangeSP;
        private System.Windows.Forms.Label label4;
    }
}