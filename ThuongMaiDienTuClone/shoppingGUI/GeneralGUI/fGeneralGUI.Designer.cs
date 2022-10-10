namespace shoppingGUI.GeneralGUI
{
    partial class fGeneralGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNHANVIEN = new System.Windows.Forms.Button();
            this.btnKHACHHANG = new System.Windows.Forms.Button();
            this.btnHANGHOA = new System.Windows.Forms.Button();
            this.btnHOADON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ BÁN HÀNG ";
            // 
            // btnNHANVIEN
            // 
            this.btnNHANVIEN.Location = new System.Drawing.Point(71, 115);
            this.btnNHANVIEN.Name = "btnNHANVIEN";
            this.btnNHANVIEN.Size = new System.Drawing.Size(487, 55);
            this.btnNHANVIEN.TabIndex = 1;
            this.btnNHANVIEN.Text = "Quản lý nhân viên";
            this.btnNHANVIEN.UseVisualStyleBackColor = true;
            this.btnNHANVIEN.Click += new System.EventHandler(this.btnNHANVIEN_Click);
            // 
            // btnKHACHHANG
            // 
            this.btnKHACHHANG.Location = new System.Drawing.Point(71, 172);
            this.btnKHACHHANG.Name = "btnKHACHHANG";
            this.btnKHACHHANG.Size = new System.Drawing.Size(487, 55);
            this.btnKHACHHANG.TabIndex = 2;
            this.btnKHACHHANG.Text = "Quản lý khách hàng";
            this.btnKHACHHANG.UseVisualStyleBackColor = true;
            this.btnKHACHHANG.Click += new System.EventHandler(this.btnKHACHHANG_Click);
            // 
            // btnHANGHOA
            // 
            this.btnHANGHOA.Location = new System.Drawing.Point(71, 230);
            this.btnHANGHOA.Name = "btnHANGHOA";
            this.btnHANGHOA.Size = new System.Drawing.Size(487, 55);
            this.btnHANGHOA.TabIndex = 3;
            this.btnHANGHOA.Text = "Quản lý hàng hóa";
            this.btnHANGHOA.UseVisualStyleBackColor = true;
            this.btnHANGHOA.Click += new System.EventHandler(this.btnHANGHOA_Click);
            // 
            // btnHOADON
            // 
            this.btnHOADON.Location = new System.Drawing.Point(71, 288);
            this.btnHOADON.Name = "btnHOADON";
            this.btnHOADON.Size = new System.Drawing.Size(487, 55);
            this.btnHOADON.TabIndex = 4;
            this.btnHOADON.Text = "Quản lý hóa đơn";
            this.btnHOADON.UseVisualStyleBackColor = true;
            this.btnHOADON.Click += new System.EventHandler(this.btnHOADON_Click);
            // 
            // fGeneralGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 412);
            this.Controls.Add(this.btnHOADON);
            this.Controls.Add(this.btnHANGHOA);
            this.Controls.Add(this.btnKHACHHANG);
            this.Controls.Add(this.btnNHANVIEN);
            this.Controls.Add(this.label1);
            this.Name = "fGeneralGUI";
            this.Text = "fGeneralGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNHANVIEN;
        private System.Windows.Forms.Button btnKHACHHANG;
        private System.Windows.Forms.Button btnHANGHOA;
        private System.Windows.Forms.Button btnHOADON;
    }
}