namespace MD5
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
            this.btGiaiMa = new System.Windows.Forms.Button();
            this.btMaHoa = new System.Windows.Forms.Button();
            this.tbDuLieuGiaiMaDuoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDuLieuMaHoaDuoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDuLieuCanMaHoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btGiaiMa
            // 
            this.btGiaiMa.Location = new System.Drawing.Point(14, 242);
            this.btGiaiMa.Name = "btGiaiMa";
            this.btGiaiMa.Size = new System.Drawing.Size(75, 23);
            this.btGiaiMa.TabIndex = 23;
            this.btGiaiMa.Text = "Giải mã";
            this.btGiaiMa.UseVisualStyleBackColor = true;
            this.btGiaiMa.Click += new System.EventHandler(this.btGiaiMa_Click);
            // 
            // btMaHoa
            // 
            this.btMaHoa.Location = new System.Drawing.Point(15, 127);
            this.btMaHoa.Name = "btMaHoa";
            this.btMaHoa.Size = new System.Drawing.Size(75, 23);
            this.btMaHoa.TabIndex = 22;
            this.btMaHoa.Text = "Mã hóa";
            this.btMaHoa.UseVisualStyleBackColor = true;
            this.btMaHoa.Click += new System.EventHandler(this.btMaHoa_Click);
            // 
            // tbDuLieuGiaiMaDuoc
            // 
            this.tbDuLieuGiaiMaDuoc.Location = new System.Drawing.Point(14, 299);
            this.tbDuLieuGiaiMaDuoc.Multiline = true;
            this.tbDuLieuGiaiMaDuoc.Name = "tbDuLieuGiaiMaDuoc";
            this.tbDuLieuGiaiMaDuoc.Size = new System.Drawing.Size(552, 56);
            this.tbDuLieuGiaiMaDuoc.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Dữ liệu giải mã được";
            // 
            // tbDuLieuMaHoaDuoc
            // 
            this.tbDuLieuMaHoaDuoc.Location = new System.Drawing.Point(15, 180);
            this.tbDuLieuMaHoaDuoc.Multiline = true;
            this.tbDuLieuMaHoaDuoc.Name = "tbDuLieuMaHoaDuoc";
            this.tbDuLieuMaHoaDuoc.Size = new System.Drawing.Size(552, 56);
            this.tbDuLieuMaHoaDuoc.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Dữ liệu mã hóa được";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Dữ liệu cần mã hóa";
            // 
            // tbDuLieuCanMaHoa
            // 
            this.tbDuLieuCanMaHoa.Location = new System.Drawing.Point(15, 64);
            this.tbDuLieuCanMaHoa.Multiline = true;
            this.tbDuLieuCanMaHoa.Name = "tbDuLieuCanMaHoa";
            this.tbDuLieuCanMaHoa.Size = new System.Drawing.Size(552, 56);
            this.tbDuLieuCanMaHoa.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Mật khẩu";
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(15, 25);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(552, 20);
            this.tbMatKhau.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 389);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.btGiaiMa);
            this.Controls.Add(this.btMaHoa);
            this.Controls.Add(this.tbDuLieuGiaiMaDuoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDuLieuMaHoaDuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDuLieuCanMaHoa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGiaiMa;
        private System.Windows.Forms.Button btMaHoa;
        private System.Windows.Forms.TextBox tbDuLieuGiaiMaDuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDuLieuMaHoaDuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDuLieuCanMaHoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMatKhau;
    }
}

