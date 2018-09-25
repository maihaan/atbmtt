namespace MD5App
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
            this.btThucHien = new System.Windows.Forms.Button();
            this.lbChonTepTin = new System.Windows.Forms.Label();
            this.btTim = new System.Windows.Forms.Button();
            this.tbDuongDan = new System.Windows.Forms.TextBox();
            this.rbGiaiMa = new System.Windows.Forms.RadioButton();
            this.rbMaHoa = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btThucHien
            // 
            this.btThucHien.BackColor = System.Drawing.Color.Orange;
            this.btThucHien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThucHien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btThucHien.Location = new System.Drawing.Point(378, 117);
            this.btThucHien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThucHien.Name = "btThucHien";
            this.btThucHien.Size = new System.Drawing.Size(143, 30);
            this.btThucHien.TabIndex = 11;
            this.btThucHien.Text = "Thực hiện";
            this.btThucHien.UseVisualStyleBackColor = false;
            this.btThucHien.Click += new System.EventHandler(this.btThucHien_Click);
            // 
            // lbChonTepTin
            // 
            this.lbChonTepTin.AutoSize = true;
            this.lbChonTepTin.Location = new System.Drawing.Point(16, 44);
            this.lbChonTepTin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChonTepTin.Name = "lbChonTepTin";
            this.lbChonTepTin.Size = new System.Drawing.Size(84, 17);
            this.lbChonTepTin.TabIndex = 10;
            this.lbChonTepTin.Text = "Chọn tệp tin";
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(448, 64);
            this.btTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(73, 28);
            this.btTim.TabIndex = 9;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // tbDuongDan
            // 
            this.tbDuongDan.Location = new System.Drawing.Point(16, 66);
            this.tbDuongDan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDuongDan.Name = "tbDuongDan";
            this.tbDuongDan.Size = new System.Drawing.Size(424, 23);
            this.tbDuongDan.TabIndex = 8;
            // 
            // rbGiaiMa
            // 
            this.rbGiaiMa.AutoSize = true;
            this.rbGiaiMa.Location = new System.Drawing.Point(105, 15);
            this.rbGiaiMa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbGiaiMa.Name = "rbGiaiMa";
            this.rbGiaiMa.Size = new System.Drawing.Size(74, 21);
            this.rbGiaiMa.TabIndex = 7;
            this.rbGiaiMa.TabStop = true;
            this.rbGiaiMa.Text = "Giải mã";
            this.rbGiaiMa.UseVisualStyleBackColor = true;
            this.rbGiaiMa.CheckedChanged += new System.EventHandler(this.rbGiaiMa_CheckedChanged);
            // 
            // rbMaHoa
            // 
            this.rbMaHoa.AutoSize = true;
            this.rbMaHoa.Location = new System.Drawing.Point(16, 15);
            this.rbMaHoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMaHoa.Name = "rbMaHoa";
            this.rbMaHoa.Size = new System.Drawing.Size(73, 21);
            this.rbMaHoa.TabIndex = 6;
            this.rbMaHoa.TabStop = true;
            this.rbMaHoa.Text = "Mã hóa";
            this.rbMaHoa.UseVisualStyleBackColor = true;
            this.rbMaHoa.CheckedChanged += new System.EventHandler(this.rbMaHoa_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mật khẩu";
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(16, 121);
            this.tbMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.PasswordChar = '*';
            this.tbMatKhau.Size = new System.Drawing.Size(354, 23);
            this.tbMatKhau.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 161);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btThucHien);
            this.Controls.Add(this.lbChonTepTin);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.tbDuongDan);
            this.Controls.Add(this.rbGiaiMa);
            this.Controls.Add(this.rbMaHoa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Mã hóa tệp tin bằng MD5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btThucHien;
        private System.Windows.Forms.Label lbChonTepTin;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.TextBox tbDuongDan;
        private System.Windows.Forms.RadioButton rbGiaiMa;
        private System.Windows.Forms.RadioButton rbMaHoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMatKhau;
    }
}

