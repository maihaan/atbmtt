namespace RSAFileEncrypt
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbMaHoa = new System.Windows.Forms.RadioButton();
            this.rbGiaiMa = new System.Windows.Forms.RadioButton();
            this.tbDuongDan = new System.Windows.Forms.TextBox();
            this.btTim = new System.Windows.Forms.Button();
            this.lbChonTepTin = new System.Windows.Forms.Label();
            this.btThucHien = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btEn = new System.Windows.Forms.Button();
            this.btVi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbMaHoa
            // 
            this.rbMaHoa.AutoSize = true;
            this.rbMaHoa.Location = new System.Drawing.Point(13, 13);
            this.rbMaHoa.Name = "rbMaHoa";
            this.rbMaHoa.Size = new System.Drawing.Size(61, 17);
            this.rbMaHoa.TabIndex = 0;
            this.rbMaHoa.TabStop = true;
            this.rbMaHoa.Text = "Mã hóa";
            this.rbMaHoa.UseVisualStyleBackColor = true;
            this.rbMaHoa.CheckedChanged += new System.EventHandler(this.rbMaHoa_CheckedChanged);
            // 
            // rbGiaiMa
            // 
            this.rbGiaiMa.AutoSize = true;
            this.rbGiaiMa.Location = new System.Drawing.Point(80, 13);
            this.rbGiaiMa.Name = "rbGiaiMa";
            this.rbGiaiMa.Size = new System.Drawing.Size(60, 17);
            this.rbGiaiMa.TabIndex = 1;
            this.rbGiaiMa.TabStop = true;
            this.rbGiaiMa.Text = "Giải mã";
            this.rbGiaiMa.UseVisualStyleBackColor = true;
            this.rbGiaiMa.CheckedChanged += new System.EventHandler(this.rbGiaiMa_CheckedChanged);
            // 
            // tbDuongDan
            // 
            this.tbDuongDan.Location = new System.Drawing.Point(13, 55);
            this.tbDuongDan.Name = "tbDuongDan";
            this.tbDuongDan.Size = new System.Drawing.Size(298, 20);
            this.tbDuongDan.TabIndex = 2;
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(317, 53);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 23);
            this.btTim.TabIndex = 3;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // lbChonTepTin
            // 
            this.lbChonTepTin.AutoSize = true;
            this.lbChonTepTin.Location = new System.Drawing.Point(13, 37);
            this.lbChonTepTin.Name = "lbChonTepTin";
            this.lbChonTepTin.Size = new System.Drawing.Size(64, 13);
            this.lbChonTepTin.TabIndex = 4;
            this.lbChonTepTin.Text = "Chọn tệp tin";
            // 
            // btThucHien
            // 
            this.btThucHien.Location = new System.Drawing.Point(13, 82);
            this.btThucHien.Name = "btThucHien";
            this.btThucHien.Size = new System.Drawing.Size(101, 38);
            this.btThucHien.TabIndex = 5;
            this.btThucHien.Text = "Thực hiện";
            this.btThucHien.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RSAFileEncrypt.Properties.Resources.phanquyen;
            this.pictureBox1.Location = new System.Drawing.Point(441, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btEn
            // 
            this.btEn.Location = new System.Drawing.Point(469, 6);
            this.btEn.Name = "btEn";
            this.btEn.Size = new System.Drawing.Size(29, 23);
            this.btEn.TabIndex = 7;
            this.btEn.Text = "En";
            this.btEn.UseVisualStyleBackColor = true;
            this.btEn.Click += new System.EventHandler(this.btEn_Click);
            // 
            // btVi
            // 
            this.btVi.Location = new System.Drawing.Point(498, 6);
            this.btVi.Name = "btVi";
            this.btVi.Size = new System.Drawing.Size(29, 23);
            this.btVi.TabIndex = 8;
            this.btVi.Text = "Vi";
            this.btVi.UseVisualStyleBackColor = true;
            this.btVi.Click += new System.EventHandler(this.btVi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 132);
            this.Controls.Add(this.btVi);
            this.Controls.Add(this.btEn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btThucHien);
            this.Controls.Add(this.lbChonTepTin);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.tbDuongDan);
            this.Controls.Add(this.rbGiaiMa);
            this.Controls.Add(this.rbMaHoa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mã hóa dữ liệu RSA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMaHoa;
        private System.Windows.Forms.RadioButton rbGiaiMa;
        private System.Windows.Forms.TextBox tbDuongDan;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Label lbChonTepTin;
        private System.Windows.Forms.Button btThucHien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btEn;
        private System.Windows.Forms.Button btVi;
    }
}

